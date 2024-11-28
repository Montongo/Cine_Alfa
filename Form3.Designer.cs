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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button7 = new Button();
            button6 = new Button();
            tercera = new Label();
            infante = new Label();
            button5 = new Button();
            button4 = new Button();
            adulto = new Label();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(439, 42);
            label1.Name = "label1";
            label1.Size = new Size(290, 29);
            label1.TabIndex = 0;
            label1.Text = "Seleccion de boletos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(397, 169);
            label2.Name = "label2";
            label2.Size = new Size(105, 37);
            label2.TabIndex = 1;
            label2.Text = "Adulto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(391, 251);
            label3.Name = "label3";
            label3.Size = new Size(111, 37);
            label3.TabIndex = 2;
            label3.Text = "Infante";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(343, 356);
            label4.Name = "label4";
            label4.Size = new Size(184, 37);
            label4.TabIndex = 3;
            label4.Text = "Tercera edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(573, 171);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 8;
            label5.Text = "$90";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(573, 260);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 9;
            label6.Text = "$60";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(573, 359);
            label7.Name = "label7";
            label7.Size = new Size(42, 25);
            label7.TabIndex = 10;
            label7.Text = "$60";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-16, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(tercera);
            panel1.Controls.Add(infante);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(adulto);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1137, 667);
            panel1.TabIndex = 13;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.next;
            pictureBox3.Location = new Point(995, 573);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(139, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.regresar1;
            pictureBox2.Location = new Point(0, 573);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.MidnightBlue;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonFace;
            button7.Location = new Point(788, 359);
            button7.Name = "button7";
            button7.Size = new Size(56, 39);
            button7.TabIndex = 21;
            button7.Text = "+";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MidnightBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(689, 352);
            button6.Name = "button6";
            button6.Size = new Size(55, 44);
            button6.TabIndex = 20;
            button6.Text = "__";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // tercera
            // 
            tercera.AutoSize = true;
            tercera.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tercera.ForeColor = SystemColors.ButtonHighlight;
            tercera.Location = new Point(750, 362);
            tercera.Name = "tercera";
            tercera.Size = new Size(20, 22);
            tercera.TabIndex = 19;
            tercera.Text = "0";
            // 
            // infante
            // 
            infante.AutoSize = true;
            infante.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            infante.ForeColor = SystemColors.ButtonHighlight;
            infante.Location = new Point(750, 282);
            infante.Name = "infante";
            infante.Size = new Size(20, 22);
            infante.TabIndex = 18;
            infante.Text = "0";
            // 
            // button5
            // 
            button5.BackColor = Color.MidnightBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(788, 267);
            button5.Name = "button5";
            button5.Size = new Size(56, 39);
            button5.TabIndex = 17;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(689, 261);
            button4.Name = "button4";
            button4.Size = new Size(55, 44);
            button4.TabIndex = 16;
            button4.Text = "__";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // adulto
            // 
            adulto.AutoSize = true;
            adulto.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adulto.ForeColor = SystemColors.ButtonHighlight;
            adulto.Location = new Point(750, 184);
            adulto.Name = "adulto";
            adulto.Size = new Size(20, 22);
            adulto.TabIndex = 15;
            adulto.Text = "0";
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(689, 163);
            button3.Name = "button3";
            button3.Size = new Size(55, 44);
            button3.TabIndex = 14;
            button3.Text = "__";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(788, 177);
            button2.Name = "button2";
            button2.Size = new Size(56, 39);
            button2.TabIndex = 13;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1136, 667);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label adulto;
        private Button button3;
        private Button button2;
        private Button button7;
        private Button button6;
        private Label tercera;
        private Label infante;
        private Button button5;
        private Button button4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}