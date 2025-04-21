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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ReadFromFileButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FileButton1511 = new System.Windows.Forms.RadioButton();
            this.FileButton74 = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RestoredMessageTextBox = new System.Windows.Forms.TextBox();
            this.DecodedFromFileTextBox = new System.Windows.Forms.TextBox();
            this.ReceivedFromFileTextBox = new System.Windows.Forms.TextBox();
            this.FileMessageTextBox = new System.Windows.Forms.TextBox();
            this.RestoreFromFileButton = new System.Windows.Forms.Button();
            this.DecodeFromFileButton = new System.Windows.Forms.Button();
            this.EncodeFromFileButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.tabPage2.Size = new System.Drawing.Size(452, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Декодирование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Статус";
            // 
            // StatusRichTextBox
            // 
            this.StatusRichTextBox.Location = new System.Drawing.Point(29, 204);
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
            this.ReceivedMessageText.Location = new System.Drawing.Point(29, 50);
            this.ReceivedMessageText.Name = "ReceivedMessageText";
            this.ReceivedMessageText.ReadOnly = true;
            this.ReceivedMessageText.Size = new System.Drawing.Size(100, 20);
            this.ReceivedMessageText.TabIndex = 11;
            // 
            // DecodedMessageText
            // 
            this.DecodedMessageText.Location = new System.Drawing.Point(29, 165);
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
            this.label5.Location = new System.Drawing.Point(26, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Декодированное сообщение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Принятая комбинация";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "ДЕКОДИРОВАТЬ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 329);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
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
            this.tabPage1.Size = new System.Drawing.Size(452, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кодирование";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Процент ошибки";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(29, 76);
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
            this.MessageText.Location = new System.Drawing.Point(29, 31);
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.Size = new System.Drawing.Size(104, 20);
            this.MessageText.TabIndex = 2;
            // 
            // EncodedMessageText
            // 
            this.EncodedMessageText.Location = new System.Drawing.Point(29, 254);
            this.EncodedMessageText.Name = "EncodedMessageText";
            this.EncodedMessageText.ReadOnly = true;
            this.EncodedMessageText.Size = new System.Drawing.Size(100, 20);
            this.EncodedMessageText.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Encode1511Button);
            this.groupBox1.Controls.Add(this.Encode74Button);
            this.groupBox1.Location = new System.Drawing.Point(29, 102);
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
            this.label2.Location = new System.Drawing.Point(26, 238);
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
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сообщение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "ЗАКОДИРОВАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ReadFromFileButton);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.numericUpDown2);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.RestoredMessageTextBox);
            this.tabPage3.Controls.Add(this.DecodedFromFileTextBox);
            this.tabPage3.Controls.Add(this.ReceivedFromFileTextBox);
            this.tabPage3.Controls.Add(this.FileMessageTextBox);
            this.tabPage3.Controls.Add(this.RestoreFromFileButton);
            this.tabPage3.Controls.Add(this.DecodeFromFileButton);
            this.tabPage3.Controls.Add(this.EncodeFromFileButton);
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(452, 303);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Файл";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ReadFromFileButton
            // 
            this.ReadFromFileButton.Location = new System.Drawing.Point(3, 228);
            this.ReadFromFileButton.Name = "ReadFromFileButton";
            this.ReadFromFileButton.Size = new System.Drawing.Size(99, 60);
            this.ReadFromFileButton.TabIndex = 17;
            this.ReadFromFileButton.Text = "Считать";
            this.ReadFromFileButton.UseVisualStyleBackColor = true;
            this.ReadFromFileButton.Click += new System.EventHandler(this.ReadFromFileButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FileButton1511);
            this.groupBox2.Controls.Add(this.FileButton74);
            this.groupBox2.Location = new System.Drawing.Point(114, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 68);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите код";
            // 
            // FileButton1511
            // 
            this.FileButton1511.AutoSize = true;
            this.FileButton1511.Location = new System.Drawing.Point(7, 44);
            this.FileButton1511.Name = "FileButton1511";
            this.FileButton1511.Size = new System.Drawing.Size(83, 17);
            this.FileButton1511.TabIndex = 1;
            this.FileButton1511.TabStop = true;
            this.FileButton1511.Text = "Код (15, 11)";
            this.FileButton1511.UseVisualStyleBackColor = true;
            this.FileButton1511.CheckedChanged += new System.EventHandler(this.FileButton1511_CheckedChanged);
            // 
            // FileButton74
            // 
            this.FileButton74.AutoSize = true;
            this.FileButton74.Location = new System.Drawing.Point(6, 21);
            this.FileButton74.Name = "FileButton74";
            this.FileButton74.Size = new System.Drawing.Size(71, 17);
            this.FileButton74.TabIndex = 0;
            this.FileButton74.TabStop = true;
            this.FileButton74.Text = "Код (7, 4)";
            this.FileButton74.UseVisualStyleBackColor = true;
            this.FileButton74.CheckedChanged += new System.EventHandler(this.FileButton74_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(329, 205);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(326, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Процент ошибки";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Выберите файл";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(255, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Восстановленное сообщение";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Принятая кодовая последовательность";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Декодированная битовая последовательность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Исходное сообщение";
            // 
            // RestoredMessageTextBox
            // 
            this.RestoredMessageTextBox.Location = new System.Drawing.Point(255, 245);
            this.RestoredMessageTextBox.Multiline = true;
            this.RestoredMessageTextBox.Name = "RestoredMessageTextBox";
            this.RestoredMessageTextBox.ReadOnly = true;
            this.RestoredMessageTextBox.Size = new System.Drawing.Size(194, 43);
            this.RestoredMessageTextBox.TabIndex = 8;
            // 
            // DecodedFromFileTextBox
            // 
            this.DecodedFromFileTextBox.Location = new System.Drawing.Point(111, 171);
            this.DecodedFromFileTextBox.Multiline = true;
            this.DecodedFromFileTextBox.Name = "DecodedFromFileTextBox";
            this.DecodedFromFileTextBox.ReadOnly = true;
            this.DecodedFromFileTextBox.Size = new System.Drawing.Size(194, 43);
            this.DecodedFromFileTextBox.TabIndex = 7;
            // 
            // ReceivedFromFileTextBox
            // 
            this.ReceivedFromFileTextBox.Location = new System.Drawing.Point(111, 103);
            this.ReceivedFromFileTextBox.Multiline = true;
            this.ReceivedFromFileTextBox.Name = "ReceivedFromFileTextBox";
            this.ReceivedFromFileTextBox.ReadOnly = true;
            this.ReceivedFromFileTextBox.Size = new System.Drawing.Size(194, 43);
            this.ReceivedFromFileTextBox.TabIndex = 6;
            // 
            // FileMessageTextBox
            // 
            this.FileMessageTextBox.Location = new System.Drawing.Point(111, 29);
            this.FileMessageTextBox.Multiline = true;
            this.FileMessageTextBox.Name = "FileMessageTextBox";
            this.FileMessageTextBox.Size = new System.Drawing.Size(194, 43);
            this.FileMessageTextBox.TabIndex = 4;
            // 
            // RestoreFromFileButton
            // 
            this.RestoreFromFileButton.Enabled = false;
            this.RestoreFromFileButton.Location = new System.Drawing.Point(362, 140);
            this.RestoreFromFileButton.Name = "RestoreFromFileButton";
            this.RestoreFromFileButton.Size = new System.Drawing.Size(87, 43);
            this.RestoreFromFileButton.TabIndex = 3;
            this.RestoreFromFileButton.Text = "Восстановить";
            this.RestoreFromFileButton.UseVisualStyleBackColor = true;
            this.RestoreFromFileButton.Click += new System.EventHandler(this.RestoreFromFileButton_Click);
            // 
            // DecodeFromFileButton
            // 
            this.DecodeFromFileButton.Enabled = false;
            this.DecodeFromFileButton.Location = new System.Drawing.Point(359, 78);
            this.DecodeFromFileButton.Name = "DecodeFromFileButton";
            this.DecodeFromFileButton.Size = new System.Drawing.Size(90, 43);
            this.DecodeFromFileButton.TabIndex = 2;
            this.DecodeFromFileButton.Text = "Декодировать";
            this.DecodeFromFileButton.UseVisualStyleBackColor = true;
            this.DecodeFromFileButton.Click += new System.EventHandler(this.DecodeFromFileButton_Click);
            // 
            // EncodeFromFileButton
            // 
            this.EncodeFromFileButton.Enabled = false;
            this.EncodeFromFileButton.Location = new System.Drawing.Point(362, 17);
            this.EncodeFromFileButton.Name = "EncodeFromFileButton";
            this.EncodeFromFileButton.Size = new System.Drawing.Size(87, 43);
            this.EncodeFromFileButton.TabIndex = 1;
            this.EncodeFromFileButton.Text = "Закодировать";
            this.EncodeFromFileButton.UseVisualStyleBackColor = true;
            this.EncodeFromFileButton.Click += new System.EventHandler(this.EncodeFromFileButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 20);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(102, 194);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(456, 324);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Кодер Хэмминга";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button RestoreFromFileButton;
        private System.Windows.Forms.Button DecodeFromFileButton;
        private System.Windows.Forms.Button EncodeFromFileButton;
        private System.Windows.Forms.TextBox RestoredMessageTextBox;
        private System.Windows.Forms.TextBox DecodedFromFileTextBox;
        private System.Windows.Forms.TextBox ReceivedFromFileTextBox;
        private System.Windows.Forms.TextBox FileMessageTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton FileButton1511;
        private System.Windows.Forms.RadioButton FileButton74;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button ReadFromFileButton;
    }
}

