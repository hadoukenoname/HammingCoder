namespace Курсовая
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.StatusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.HMatrixText = new System.Windows.Forms.TextBox();
            this.ReceivedMessageText = new System.Windows.Forms.TextBox();
            this.DecodedMessageText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GMatrixText = new System.Windows.Forms.TextBox();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.EncodedMessageText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Encode1511Button = new System.Windows.Forms.RadioButton();
            this.Encode74Button = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.StatusRichTextBox);
            this.tabPage2.Controls.Add(this.HMatrixText);
            this.tabPage2.Controls.Add(this.ReceivedMessageText);
            this.tabPage2.Controls.Add(this.DecodedMessageText);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Декодирование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Статус";
            // 
            // StatusRichTextBox
            // 
            this.StatusRichTextBox.Location = new System.Drawing.Point(29, 157);
            this.StatusRichTextBox.Name = "StatusRichTextBox";
            this.StatusRichTextBox.ReadOnly = true;
            this.StatusRichTextBox.Size = new System.Drawing.Size(170, 60);
            this.StatusRichTextBox.TabIndex = 15;
            this.StatusRichTextBox.Text = "";
            // 
            // HMatrixText
            // 
            this.HMatrixText.Location = new System.Drawing.Point(262, 76);
            this.HMatrixText.Multiline = true;
            this.HMatrixText.Name = "HMatrixText";
            this.HMatrixText.ReadOnly = true;
            this.HMatrixText.Size = new System.Drawing.Size(173, 81);
            this.HMatrixText.TabIndex = 14;
            // 
            // ReceivedMessageText
            // 
            this.ReceivedMessageText.Location = new System.Drawing.Point(29, 75);
            this.ReceivedMessageText.Name = "ReceivedMessageText";
            this.ReceivedMessageText.ReadOnly = true;
            this.ReceivedMessageText.Size = new System.Drawing.Size(100, 20);
            this.ReceivedMessageText.TabIndex = 11;
            // 
            // DecodedMessageText
            // 
            this.DecodedMessageText.Location = new System.Drawing.Point(533, 76);
            this.DecodedMessageText.Name = "DecodedMessageText";
            this.DecodedMessageText.ReadOnly = true;
            this.DecodedMessageText.Size = new System.Drawing.Size(100, 20);
            this.DecodedMessageText.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Проверочная матрица";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Декодированное сообщение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Принятая комбинация";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "ДЕКОДИРОВАТЬ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.GMatrixText);
            this.tabPage1.Controls.Add(this.MessageText);
            this.tabPage1.Controls.Add(this.EncodedMessageText);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кодирование";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Вероятность ошибки";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(29, 151);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // GMatrixText
            // 
            this.GMatrixText.Location = new System.Drawing.Point(278, 75);
            this.GMatrixText.Multiline = true;
            this.GMatrixText.Name = "GMatrixText";
            this.GMatrixText.ReadOnly = true;
            this.GMatrixText.Size = new System.Drawing.Size(140, 150);
            this.GMatrixText.TabIndex = 9;
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(29, 75);
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.Size = new System.Drawing.Size(104, 20);
            this.MessageText.TabIndex = 2;
            // 
            // EncodedMessageText
            // 
            this.EncodedMessageText.Location = new System.Drawing.Point(533, 76);
            this.EncodedMessageText.Name = "EncodedMessageText";
            this.EncodedMessageText.ReadOnly = true;
            this.EncodedMessageText.Size = new System.Drawing.Size(100, 20);
            this.EncodedMessageText.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Encode1511Button);
            this.groupBox1.Controls.Add(this.Encode74Button);
            this.groupBox1.Location = new System.Drawing.Point(29, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите код";
            // 
            // Encode1511Button
            // 
            this.Encode1511Button.AutoSize = true;
            this.Encode1511Button.Location = new System.Drawing.Point(6, 42);
            this.Encode1511Button.Name = "Encode1511Button";
            this.Encode1511Button.Size = new System.Drawing.Size(83, 17);
            this.Encode1511Button.TabIndex = 1;
            this.Encode1511Button.TabStop = true;
            this.Encode1511Button.Text = "Код (15, 11)";
            this.Encode1511Button.UseVisualStyleBackColor = true;
            this.Encode1511Button.CheckedChanged += new System.EventHandler(this.Encode1511Button_CheckedChanged);
            // 
            // Encode74Button
            // 
            this.Encode74Button.AutoSize = true;
            this.Encode74Button.Location = new System.Drawing.Point(6, 19);
            this.Encode74Button.Name = "Encode74Button";
            this.Encode74Button.Size = new System.Drawing.Size(71, 17);
            this.Encode74Button.TabIndex = 0;
            this.Encode74Button.TabStop = true;
            this.Encode74Button.Text = "Код (7, 4)";
            this.Encode74Button.UseVisualStyleBackColor = true;
            this.Encode74Button.CheckedChanged += new System.EventHandler(this.Encode74Button_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(509, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Закодированное сообщение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Порождающая матрица";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сообщение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "ЗАКОДИРОВАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 373);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 371);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Кодер Хэмминга";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox HMatrixText;
        private System.Windows.Forms.TextBox ReceivedMessageText;
        private System.Windows.Forms.TextBox DecodedMessageText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox GMatrixText;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.TextBox EncodedMessageText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Encode1511Button;
        private System.Windows.Forms.RadioButton Encode74Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox StatusRichTextBox;
    }
}

