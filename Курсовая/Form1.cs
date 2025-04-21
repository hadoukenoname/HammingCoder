using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFilesAndFolders("D:/");
           
        }

        private void LoadFilesAndFolders(string path)
        {
            try
            {
                // Очистить TreeView перед загрузкой новых данных
                treeView1.Nodes.Clear();

                // Создать корневой узел для указанной директории
                TreeNode rootNode = new TreeNode(path);
                treeView1.Nodes.Add(rootNode);

                // Загрузить подкаталоги и файлы
                LoadDirectory(rootNode, path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файлов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDirectory(TreeNode parentNode, string path)
        {
            try
            {
                // Получить все подкаталоги
                string[] directories = Directory.GetDirectories(path);
                foreach (string directory in directories)
                {
                    // Создать узел для каждой папки
                    TreeNode dirNode = new TreeNode(new DirectoryInfo(directory).Name);
                    parentNode.Nodes.Add(dirNode);

                    // Рекурсивно загрузить содержимое подкаталога
                    LoadDirectory(dirNode, directory);
                }

                // Получить все файлы в текущей директории
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    // Создать узел для каждого файла
                    TreeNode fileNode = new TreeNode(new FileInfo(file).Name);
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Доступ запрещен");
            }
            catch (Exception ex)
            {
                parentNode.Nodes.Add($"Ошибка: {ex.Message}");
            }
        }



        private string GetFullPath(TreeNode node)
        {
            // Используем StringBuilder для сборки пути
            StringBuilder pathBuilder = new StringBuilder();

            // Проходим по всем родительским узлам
            while (node != null)
            {
                // Добавляем имя узла к пути
                pathBuilder.Insert(0, node.Text);

                // Если это не корневой узел, добавляем одинарный слеш
                if (node.Parent != null)
                {
                    pathBuilder.Insert(0, "/");
                }

                // Переходим к родительскому узлу
                node = node.Parent;
            }

            // Преобразуем путь: заменяем обратные слеши на обычные слеши
            return pathBuilder.ToString().Replace("//", "/"); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int expectedLength = Encode74Button.Checked ? 4 : 11;
            int[] result = HammingCoder.MakeErros((int)numericUpDown1.Value, HammingCoder.Encode(HammingCoder.ConvertToArray(MessageText.Text)));

            if (!CheckCorrect(MessageText, expectedLength) || result.Length == 0)
                Error(EncodedMessageText);
            else
            {
                ShowArray(result, EncodedMessageText);
                ShowArray(result, ReceivedMessageText);

                PrintStatus("Encoded", StatusRichTextBox);
            }                
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<int> mistakes = HammingCoder.Missmatch(HammingCoder.ConvertToArray(ReceivedMessageText.Text), HammingCoder.Encode(HammingCoder.ConvertToArray(MessageText.Text)));
            int[] result = HammingCoder.Decode(HammingCoder.ConvertToArray(ReceivedMessageText.Text));

            switch (mistakes.Count)
            {
                case 0:
                    PrintStatus("NoMistakes", StatusRichTextBox);                    
                    break;

                case 1:
                    PrintStatus("OneMistake", StatusRichTextBox);                    
                    break;

                default:
                    PrintStatus("Unable", StatusRichTextBox);
                    break;                   
            }

            ShowArray(result, DecodedMessageText);
        }

        private void Encode74Button_CheckedChanged(object sender, EventArgs e)
        {
            ShowMatrix(HammingCoder.GetG(0), GMatrixText);
            ShowMatrix(HammingCoder.GetH(0), HMatrixText);
            MessageText.ReadOnly = false;
        }

        private void Encode1511Button_CheckedChanged(object sender, EventArgs e)
        {
            ShowMatrix(HammingCoder.GetG(1), GMatrixText);
            ShowMatrix(HammingCoder.GetH(1), HMatrixText);
            MessageText.ReadOnly = false;
        }
        

        private StringBuilder BuildMatrix(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j] + " ");
                }
                sb.AppendLine(); 
            }
            return sb;
        }

        private void BuildScales(int[,] matrix, TextBox textbox)
        {
            textbox.Width = matrix.GetLength(1) == 7 ? 70 : 140;            
            textbox.Left = matrix.GetLength(1) == 7 ? 312 : 278;
            switch(matrix.GetLength(0))
            {
                case 4:
                    textbox.Height = 60;
                    break;

                case 11:
                    textbox.Height = 150;
                    break;

                case 3:
                    textbox.Height = 45;
                    break;
            }            
        }

        private void ShowMatrix(int[,] matrix, TextBox textbox)
        {                        
            textbox.Text = BuildMatrix(matrix).ToString();
            BuildScales(matrix, textbox);
        }
        
        private void ShowArray(int[] array, TextBox textbox)
        {   
            textbox.Text = String.Join("", array);
        }

        private void Error(TextBox textbox)
        {
            textbox.Text = "Код некорректен";
        }
        
        private bool CheckCorrect(TextBox inputText, int expectedLength)
        {
            bool isCorrect = true;

            if (inputText.Text.Length != expectedLength)            
                isCorrect = false;                
            
            return isCorrect;
        }

        private void PrintStatus(string status, RichTextBox StatusRichTextBox)
        {
            switch(status)
            {
                case "Encoded":
                    StatusRichTextBox.Text = "Кодовая комбинация принята и готова к декодированию";
                    break;

                case "NoMistakes":
                    StatusRichTextBox.Text = "Сообщение успешно декодировано, ошибок не обнаружено";
                    break;

                case "OneMistake":
                    string message = "Сообщение успешно декодировано, исправлена одна ошибка: ";
                    
                    List<int> index = HammingCoder.Missmatch(HammingCoder.ConvertToArray(ReceivedMessageText.Text), HammingCoder.Encode(HammingCoder.ConvertToArray(MessageText.Text)));

                    StatusRichTextBox.Text = message + string.Join("", HammingCoder.CorrectErrors(HammingCoder.ConvertToArray(ReceivedMessageText.Text)));
                    StatusRichTextBox.SelectionStart = message.Length + index[0];
                    StatusRichTextBox.SelectionLength = 1;
                    StatusRichTextBox.SelectionBackColor = Color.Green;
                    StatusRichTextBox.SelectionColor = Color.White;
                    break;

                case "Unable":
                    StatusRichTextBox.Text = "Обнаружены две или более ошибки, корректное декодирование невозможно";
                    break;

                default:
                    StatusRichTextBox.Text = "";
                    break;
            }
        }

        private void PrintMatrixAsBlocks(int[,] matrix, TextBox textbox)
        {
            string result = "";
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += matrix[i, j];
                }

                result += '\t';
            }

            textbox.Text = result;
        }

        private void FileButton74_CheckedChanged(object sender, EventArgs e)
        {
            EncodeFromFileButton.Enabled = true;
        }

        private void FileButton1511_CheckedChanged(object sender, EventArgs e)
        {
            EncodeFromFileButton.Enabled = true;
        }

        private void EncodeFromFileButton_Click(object sender, EventArgs e)
        {
            HammingCoder.HammingCodeType codetype = FileButton74.Checked ? HammingCoder.HammingCodeType.Code7_4 : HammingCoder.HammingCodeType.Code15_11;
            int[,] result = HammingCoder.EncodeText(FileMessageTextBox.Text, codetype);
            HammingCoder.MakeErrors((int)numericUpDown2.Value, result);

            PrintMatrixAsBlocks(result, ReceivedFromFileTextBox);
            DecodeFromFileButton.Enabled = true;
        }

        private void ReadFromFileButton_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Файл не выбран");
            }
            else
            {               
                FileMessageTextBox.Text = File.ReadAllText(GetFullPath(treeView1.SelectedNode));
            }                
        }

        private void DecodeFromFileButton_Click(object sender, EventArgs e)
        {
            HammingCoder.HammingCodeType codetype = FileButton74.Checked ? HammingCoder.HammingCodeType.Code7_4 : HammingCoder.HammingCodeType.Code15_11;
            int[,] received = HammingCoder.ConvertTextToMatrix(ReceivedFromFileTextBox.Text);
            int[,] decoded = HammingCoder.DecodeParsed(received, codetype);

            PrintMatrixAsBlocks(decoded, DecodedFromFileTextBox);
            RestoreFromFileButton.Enabled = true;            
        }

        private void RestoreFromFileButton_Click(object sender, EventArgs e)
        {
            int[,] decoded = HammingCoder.ConvertTextToMatrix(DecodedFromFileTextBox.Text);
            string result = HammingCoder.ConvertBinaryArrayToText(HammingCoder.MatrixToBinary(decoded));

            RestoredMessageTextBox.Text = result;
        }
    }
}