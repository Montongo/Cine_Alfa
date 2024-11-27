namespace Cine_Alfa
{
    partial class new_user
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
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            confirma_contra = new TextBox();
            ingresa_contra = new TextBox();
            ingresa_user = new TextBox();
            ingresa_nombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(confirma_contra);
            panel1.Controls.Add(ingresa_contra);
            panel1.Controls.Add(ingresa_user);
            panel1.Controls.Add(ingresa_nombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 561);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(230, 412);
            label6.Name = "label6";
            label6.Size = new Size(210, 22);
            label6.TabIndex = 15;
            label6.Text = "Confirmar contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(230, 350);
            label5.Name = "label5";
            label5.Size = new Size(110, 22);
            label5.TabIndex = 14;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(230, 286);
            label4.Name = "label4";
            label4.Size = new Size(80, 22);
            label4.TabIndex = 13;
            label4.Text = "Usuario";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(782, 41);
            panel2.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(381, 489);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // confirma_contra
            // 
            confirma_contra.Location = new Point(488, 410);
            confirma_contra.Name = "confirma_contra";
            confirma_contra.Size = new Size(125, 27);
            confirma_contra.TabIndex = 9;
            // 
            // ingresa_contra
            // 
            ingresa_contra.Location = new Point(488, 350);
            ingresa_contra.Name = "ingresa_contra";
            ingresa_contra.Size = new Size(125, 27);
            ingresa_contra.TabIndex = 8;
            // 
            // ingresa_user
            // 
            ingresa_user.Location = new Point(488, 286);
            ingresa_user.Name = "ingresa_user";
            ingresa_user.Size = new Size(125, 27);
            ingresa_user.TabIndex = 7;
            // 
            // ingresa_nombre
            // 
            ingresa_nombre.Location = new Point(488, 229);
            ingresa_nombre.Name = "ingresa_nombre";
            ingresa_nombre.Size = new Size(125, 27);
            ingresa_nombre.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(230, 229);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(254, 126);
            label2.Name = "label2";
            label2.Size = new Size(300, 22);
            label2.TabIndex = 1;
            label2.Text = "Ingresa los datos solicitados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(299, 64);
            label1.Name = "label1";
            label1.Size = new Size(176, 29);
            label1.TabIndex = 0;
            label1.Text = "Crear cuenta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_cine;
            pictureBox1.Location = new Point(3, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // new_user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 559);
            Controls.Add(panel1);
            Name = "new_user";
            Text = "new_user";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox confirma_contra;
        private TextBox ingresa_contra;
        private TextBox ingresa_user;
        private TextBox ingresa_nombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}