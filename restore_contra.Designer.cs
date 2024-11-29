namespace Cine_Alfa
{
    partial class restore_contra
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
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            confirmar_contra = new TextBox();
            ingresar_contra = new TextBox();
            ingresar_usuario = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(confirmar_contra);
            panel1.Controls.Add(ingresar_contra);
            panel1.Controls.Add(ingresar_usuario);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 494);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(221, 321);
            label5.Name = "label5";
            label5.Size = new Size(210, 22);
            label5.TabIndex = 11;
            label5.Text = "Confirmar contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(221, 261);
            label4.Name = "label4";
            label4.Size = new Size(170, 22);
            label4.TabIndex = 10;
            label4.Text = "Nueva contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(0, 0, 64);
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(788, 50);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // confirmar_contra
            // 
            confirmar_contra.Location = new Point(479, 321);
            confirmar_contra.Name = "confirmar_contra";
            confirmar_contra.Size = new Size(125, 27);
            confirmar_contra.TabIndex = 8;
            confirmar_contra.TextChanged += textBox3_TextChanged;
            // 
            // ingresar_contra
            // 
            ingresar_contra.Location = new Point(479, 259);
            ingresar_contra.Name = "ingresar_contra";
            ingresar_contra.Size = new Size(125, 27);
            ingresar_contra.TabIndex = 7;
            // 
            // ingresar_usuario
            // 
            ingresar_usuario.Location = new Point(479, 202);
            ingresar_usuario.Name = "ingresar_usuario";
            ingresar_usuario.Size = new Size(125, 27);
            ingresar_usuario.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(362, 430);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(221, 207);
            label3.Name = "label3";
            label3.Size = new Size(80, 22);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(166, 108);
            label2.Name = "label2";
            label2.Size = new Size(549, 23);
            label2.TabIndex = 1;
            label2.Text = "Ingresa los datos para restablecer tu contraseña.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(280, 65);
            label1.Name = "label1";
            label1.Size = new Size(291, 29);
            label1.TabIndex = 0;
            label1.Text = "Restaurar contraseña";
            // 
            // pictureBox2
            // 
       
            pictureBox2.Location = new Point(-23, 297);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 194);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // restore_contra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 494);
            Controls.Add(panel1);
            Name = "restore_contra";
            Text = "restore_contra";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox confirmar_contra;
        private TextBox ingresar_contra;
        private TextBox ingresar_usuario;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
    }
}