using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Курсовая
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

                PrintStatus("Encoded");
            }                
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<int> mistakes = HammingCoder.Missmatch(HammingCoder.ConvertToArray(ReceivedMessageText.Text), HammingCoder.Encode(HammingCoder.ConvertToArray(MessageText.Text)));
            int[] result = HammingCoder.Decode(HammingCoder.ConvertToArray(ReceivedMessageText.Text));

            switch (mistakes.Count)
            {
                case 0:
                    PrintStatus("NoMistakes");                    
                    break;

                case 1:
                    PrintStatus("OneMistake");                    
                    break;

                default:
                    PrintStatus("Unable");
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

        private void PrintStatus(string status)
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

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (EncodedMessageText.Text.Length == 0)
                return;
            if (EncodedMessageText.Text.Length == 7)
                ShowMatrix(HammingCoder.GetH(0), HMatrixText);
            else
                ShowMatrix(HammingCoder.GetH(1), HMatrixText);
        }
    }
}