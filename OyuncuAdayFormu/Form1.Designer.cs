﻿namespace OyuncuAdayFormu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 63);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "AdSoyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 106);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 0;
            label2.Text = "Yaş";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 154);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 0;
            label3.Text = "Boy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 294);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 0;
            label4.Text = "SaçRengi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 244);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 0;
            label5.Text = "GözRengi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 196);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 0;
            label6.Text = "Fiziksel";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(96, 188);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 1;
            textBox4.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kızıl", "Sarı", "Kahverengi", "Siyah" });
            comboBox1.Location = new Point(96, 286);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Khverengi", "Mavi", "Ela", "Yeşil" });
            comboBox2.Location = new Point(96, 241);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 22);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Info;
            label8.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(315, 22);
            label8.Name = "label8";
            label8.Size = new Size(253, 28);
            label8.TabIndex = 5;
            label8.Text = "OYUNCU ADAY FORMU";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 361);
            button1.Name = "button1";
            button1.Size = new Size(151, 23);
            button1.TabIndex = 6;
            button1.Text = "Bilgileri Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}
