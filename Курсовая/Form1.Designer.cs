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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EncodedMessageText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GMatrixText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Encode1511Button = new System.Windows.Forms.RadioButton();
            this.Encode74Button = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.HMatrixText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Decode1511Button = new System.Windows.Forms.RadioButton();
            this.Decode74Button = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReceivedMessageText = new System.Windows.Forms.TextBox();
            this.DecodedMessageText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "ЗАКОДИРОВАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(29, 75);
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.Size = new System.Drawing.Size(104, 20);
            this.MessageText.TabIndex = 2;
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
            // EncodedMessageText
            // 
            this.EncodedMessageText.Location = new System.Drawing.Point(533, 76);
            this.EncodedMessageText.Name = "EncodedMessageText";
            this.EncodedMessageText.ReadOnly = true;
            this.EncodedMessageText.Size = new System.Drawing.Size(100, 20);
            this.EncodedMessageText.TabIndex = 4;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 373);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GMatrixText);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.MessageText);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.EncodedMessageText);
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
            // GMatrixText
            // 
            this.GMatrixText.Location = new System.Drawing.Point(278, 75);
            this.GMatrixText.Multiline = true;
            this.GMatrixText.Name = "GMatrixText";
            this.GMatrixText.ReadOnly = true;
            this.GMatrixText.Size = new System.Drawing.Size(140, 150);
            this.GMatrixText.TabIndex = 9;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.HMatrixText);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.ReceivedMessageText);
            this.tabPage2.Controls.Add(this.DecodedMessageText);
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
            // HMatrixText
            // 
            this.HMatrixText.Location = new System.Drawing.Point(262, 76);
            this.HMatrixText.Multiline = true;
            this.HMatrixText.Name = "HMatrixText";
            this.HMatrixText.ReadOnly = true;
            this.HMatrixText.Size = new System.Drawing.Size(173, 81);
            this.HMatrixText.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Decode1511Button);
            this.groupBox2.Controls.Add(this.Decode74Button);
            this.groupBox2.Location = new System.Drawing.Point(29, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 70);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите код";
            // 
            // Decode1511Button
            // 
            this.Decode1511Button.AutoSize = true;
            this.Decode1511Button.Location = new System.Drawing.Point(6, 42);
            this.Decode1511Button.Name = "Decode1511Button";
            this.Decode1511Button.Size = new System.Drawing.Size(83, 17);
            this.Decode1511Button.TabIndex = 1;
            this.Decode1511Button.TabStop = true;
            this.Decode1511Button.Text = "Код (15, 11)";
            this.Decode1511Button.UseVisualStyleBackColor = true;
            this.Decode1511Button.CheckedChanged += new System.EventHandler(this.Decode1511Button_CheckedChanged);
            // 
            // Decode74Button
            // 
            this.Decode74Button.AutoSize = true;
            this.Decode74Button.Location = new System.Drawing.Point(6, 19);
            this.Decode74Button.Name = "Decode74Button";
            this.Decode74Button.Size = new System.Drawing.Size(71, 17);
            this.Decode74Button.TabIndex = 0;
            this.Decode74Button.TabStop = true;
            this.Decode74Button.Text = "Код (7, 4)";
            this.Decode74Button.UseVisualStyleBackColor = true;
            this.Decode74Button.CheckedChanged += new System.EventHandler(this.Decode74Button_CheckedChanged);
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
            this.button2.Location = new System.Drawing.Point(262, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 63);
            this.button2.TabIndex = 10;
            this.button2.Text = "ДЕКОДИРОВАТЬ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 372);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Кодер Хэмминга";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EncodedMessageText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ReceivedMessageText;
        private System.Windows.Forms.TextBox DecodedMessageText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Encode1511Button;
        private System.Windows.Forms.RadioButton Encode74Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Decode74Button;
        private System.Windows.Forms.RadioButton Decode1511Button;
        private System.Windows.Forms.TextBox GMatrixText;
        private System.Windows.Forms.TextBox HMatrixText;
    }
}

