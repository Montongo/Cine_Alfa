namespace Cine_Alfa
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Impact", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(466, 51);
            label1.Name = "label1";
            label1.Size = new Size(357, 45);
            label1.TabIndex = 0;
            label1.Text = "Seleccion de boletos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(376, 154);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 1;
            label2.Text = "Adulto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Book", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(372, 250);
            label3.Name = "label3";
            label3.Size = new Size(99, 36);
            label3.TabIndex = 2;
            label3.Text = "Infante";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(315, 346);
            label4.Name = "label4";
            label4.Size = new Size(175, 37);
            label4.TabIndex = 3;
            label4.Text = "Tercera edad";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(634, 154);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox2.Location = new Point(634, 258);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox3.Location = new Point(634, 356);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(895, 411);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 162);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 8;
            label5.Text = "40$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(501, 260);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 9;
            label6.Text = "25$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(501, 359);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 10;
            label7.Text = "30$";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 673);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}