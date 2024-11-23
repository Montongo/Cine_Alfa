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
            label1 = new Label();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumSpringGreen;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(108, 90);
            label1.Name = "label1";
            label1.Size = new Size(197, 57);
            label1.TabIndex = 0;
            label1.Text = "Alfa fan";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CadetBlue;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 244);
            label2.Name = "label2";
            label2.Size = new Size(116, 41);
            label2.TabIndex = 1;
            label2.Text = "Codigo";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 244);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
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
            label3.Location = new Point(910, 73);
            label3.Name = "label3";
            label3.Size = new Size(304, 302);
            label3.TabIndex = 3;
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(982, 423);
            button1.Name = "button1";
            button1.Size = new Size(168, 29);
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
            groupBox1.Location = new Point(618, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(119, 242);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Horarios ";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(8, 166);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(82, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "9:00 PM";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(8, 88);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "6:00 PM";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(8, 30);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(82, 24);
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
            groupBox2.Location = new Point(762, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(128, 242);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dia";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(6, 144);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(78, 24);
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
            radioButton6.Size = new Size(81, 24);
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
            radioButton5.Size = new Size(72, 24);
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
            radioButton4.Size = new Size(67, 24);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Lunes";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(824, 586);
            button2.Name = "button2";
            button2.Size = new Size(349, 108);
            button2.TabIndex = 7;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 313);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(577, 381);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.abstract_background_design_background_design_free_photo;
            ClientSize = new Size(1262, 721);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
    }
}