namespace Cine_Alfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            Ingresa_usuario = new TextBox();
            Ingresa_password = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.DarkRed;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(520, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(395, 314);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlText;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(395, 428);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Ingresa_usuario
            // 
            Ingresa_usuario.Location = new Point(532, 312);
            Ingresa_usuario.Name = "Ingresa_usuario";
            Ingresa_usuario.Size = new Size(230, 27);
            Ingresa_usuario.TabIndex = 3;
            Ingresa_usuario.TextChanged += textBox1_TextChanged;
            // 
            // Ingresa_password
            // 
            Ingresa_password.Location = new Point(534, 427);
            Ingresa_password.Name = "Ingresa_password";
            Ingresa_password.Size = new Size(228, 27);
            Ingresa_password.TabIndex = 4;
            Ingresa_password.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(835, 494);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.james_lee_YpDkIh137ws_unsplash;
            ClientSize = new Size(1262, 673);
            Controls.Add(button1);
            Controls.Add(Ingresa_password);
            Controls.Add(Ingresa_usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox Ingresa_usuario;
        private TextBox Ingresa_password;
        private Button button1;
    }
}
