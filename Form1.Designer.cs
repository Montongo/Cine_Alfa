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
            button2 = new Button();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            create_cuen = new Button();
            label4 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-17, 196);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(318, 275);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(318, 357);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Ingresa_usuario
            // 
            Ingresa_usuario.Location = new Point(482, 275);
            Ingresa_usuario.Margin = new Padding(3, 4, 3, 4);
            Ingresa_usuario.Name = "Ingresa_usuario";
            Ingresa_usuario.Size = new Size(230, 27);
            Ingresa_usuario.TabIndex = 3;
            Ingresa_usuario.TextChanged += textBox1_TextChanged;
            // 
            // Ingresa_password
            // 
            Ingresa_password.Location = new Point(482, 358);
            Ingresa_password.Margin = new Padding(3, 4, 3, 4);
            Ingresa_password.Name = "Ingresa_password";
            Ingresa_password.Size = new Size(228, 27);
            Ingresa_password.TabIndex = 4;
            Ingresa_password.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(541, 431);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Location = new Point(27, 657);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(202, 29);
            button2.TabIndex = 6;
            button2.Text = "terminos y condiciones";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(create_cuen);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Ingresa_password);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Ingresa_usuario);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 714);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Yellow;
            linkLabel1.Location = new Point(512, 511);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(149, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Olvide mi contraseña";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(493, 579);
            label5.Name = "label5";
            label5.Size = new Size(190, 22);
            label5.TabIndex = 8;
            label5.Text = "¿No tienes cuenta?";
            // 
            // create_cuen
            // 
            create_cuen.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            create_cuen.Location = new Point(519, 632);
            create_cuen.Name = "create_cuen";
            create_cuen.Size = new Size(142, 45);
            create_cuen.TabIndex = 7;
            create_cuen.Text = "Crear cuenta";
            create_cuen.UseVisualStyleBackColor = true;
            create_cuen.Click += create_cuen_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(217, 108);
            label4.Name = "label4";
            label4.Size = new Size(659, 138);
            label4.TabIndex = 2;
            label4.Text = "Ingresa tu nombre de usuario y tu contraseña, después dale \r\nal botón de continuar.\r\n\r\n\r\n\r\n\r\n";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(424, 42);
            label3.Name = "label3";
            label3.Size = new Size(209, 34);
            label3.TabIndex = 1;
            label3.Text = "Iniciar sesión";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.USUA;
            pictureBox2.Location = new Point(519, 196);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 714);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox Ingresa_usuario;
        private TextBox Ingresa_password;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label5;
        private Button create_cuen;
        private PictureBox pictureBox2;
    }
}
