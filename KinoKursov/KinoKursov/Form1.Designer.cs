namespace KinoKursov
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
            panel1 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 128);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(103, 28);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 0;
            label1.Text = "Кино - Звезда";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Premiera - 12,00", "Normalno - 7,50", "Namaleno - 5,00" });
            comboBox1.Location = new Point(164, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 29);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Italic);
            textBox1.Location = new Point(164, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 32);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 12F, FontStyle.Italic);
            textBox2.Location = new Point(164, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 32);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Italic);
            label2.Location = new Point(36, 32);
            label2.Name = "label2";
            label2.Size = new Size(122, 24);
            label2.TabIndex = 4;
            label2.Text = "Прожекция:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Italic);
            label3.Location = new Point(36, 88);
            label3.Name = "label3";
            label3.Size = new Size(50, 24);
            label3.TabIndex = 5;
            label3.Text = "Ред:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Italic);
            label4.Location = new Point(36, 150);
            label4.Name = "label4";
            label4.Size = new Size(84, 24);
            label4.TabIndex = 6;
            label4.Text = "Колона:";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Italic);
            button1.Location = new Point(260, 199);
            button1.Name = "button1";
            button1.Size = new Size(103, 32);
            button1.TabIndex = 7;
            button1.Text = "Изчисли";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Italic);
            label5.Location = new Point(27, 370);
            label5.Name = "label5";
            label5.Size = new Size(98, 24);
            label5.TabIndex = 8;
            label5.Text = "Резултат:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 128);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(27, 121);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 237);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 411);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private GroupBox groupBox1;
    }
}
