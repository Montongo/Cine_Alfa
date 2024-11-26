namespace Cine_Alfa
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label2 = new Label();
            textBox1 = new TextBox();
            peliculas = new ImageList(components);
            label3 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            atras2 = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CadetBlue;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 200);
            label2.Name = "label2";
            label2.Size = new Size(116, 41);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 2;
            // 
            // peliculas
            // 
            peliculas.ColorDepth = ColorDepth.Depth32Bit;
            peliculas.ImageStream = (ImageListStreamer)resources.GetObject("peliculas.ImageStream");
            peliculas.TransparentColor = Color.Transparent;
            peliculas.Images.SetKeyName(0, "518jo3Xlf8L._AC_UF894,1000_QL80_.jpg");
            peliculas.Images.SetKeyName(1, "dye_300x300.jpg");
            peliculas.Images.SetKeyName(2, "images (1).jpg");
            peliculas.Images.SetKeyName(3, "images.jpg");
            peliculas.Images.SetKeyName(4, "una_esposa_de_mentira.jpg");
            // 
            // label3
            // 
            label3.ImageIndex = 0;
            label3.ImageList = peliculas;
            label3.Location = new Point(912, 64);
            label3.Name = "label3";
            label3.Size = new Size(304, 302);
            label3.TabIndex = 3;
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(912, 389);
            button1.Name = "button1";
            button1.Size = new Size(304, 40);
            button1.TabIndex = 4;
            button1.Text = "Cambiar pelicula";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(612, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(125, 242);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Horarios ";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(8, 166);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(97, 27);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "9:00 PM";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(8, 88);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(97, 27);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "6:00 PM";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(8, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(97, 27);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "3:00 PM";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(762, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(128, 242);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dia";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 144);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(89, 27);
            radioButton7.TabIndex = 3;
            radioButton7.TabStop = true;
            radioButton7.Text = "Viernes";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(6, 189);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(91, 27);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "Sabado";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 88);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(83, 27);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Jueves";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 30);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(76, 27);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Lunes";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(992, 616);
            button2.Name = "button2";
            button2.Size = new Size(224, 49);
            button2.TabIndex = 7;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(577, 369);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // atras2
            // 
            atras2.BackColor = SystemColors.Info;
            atras2.FlatStyle = FlatStyle.System;
            atras2.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atras2.Location = new Point(12, 616);
            atras2.Name = "atras2";
            atras2.Size = new Size(162, 49);
            atras2.TabIndex = 9;
            atras2.Text = "Atras";
            atras2.UseVisualStyleBackColor = false;
            atras2.Click += atras2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.abstract_background_design_background_design_free_photo;
            ClientSize = new Size(1234, 677);
            Controls.Add(pictureBox1);
            Controls.Add(atras2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private ImageList peliculas;
        private Label label3;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox2;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton7;
        private Button button2;
        private DataGridView dataGridView1;
        private Button atras2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
    }
}