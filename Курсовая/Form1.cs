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
            int[] result = HammingCoder.Encode(HammingCoder.ConvertToArray(MessageText.Text));

            if (!CheckCorrect(MessageText, expectedLength) || result.Length == 0)
                Error(EncodedMessageText);
            else
                ShowArray(result, EncodedMessageText);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int expectedLength = Decode74Button.Checked ? 7 : 15;
            int[] result = HammingCoder.Decode(HammingCoder.ConvertToArray(ReceivedMessageText.Text));

            if (!CheckCorrect(ReceivedMessageText, expectedLength) || result.Length == 0)
                Error(DecodedMessageText);
            else
                ShowArray(result, DecodedMessageText);
        }

        private void Encode74Button_CheckedChanged(object sender, EventArgs e)
        {
            ShowMatrix(HammingCoder.GetG(0), GMatrixText);
            MessageText.ReadOnly = false;
        }

        private void Encode1511Button_CheckedChanged(object sender, EventArgs e)
        {
            ShowMatrix(HammingCoder.GetG(1), GMatrixText);
            MessageText.ReadOnly = false;
        }

        private void Decode74Button_CheckedChanged(object sender, EventArgs e)
        {
            ShowMatrix(HammingCoder.GetH(0), HMatrixText);
            ReceivedMessageText.ReadOnly = false;
        }

        private void Decode1511Button_CheckedChanged(object sender, EventArgs e)
        {
            ShowMatrix(HammingCoder.GetH(1), HMatrixText);
            ReceivedMessageText.ReadOnly = false;
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
    }
}