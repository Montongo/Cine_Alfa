namespace Cine_Alfa.Peliculas
{
    partial class Play1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play1));
            pictureBox1 = new PictureBox();
            atras3 = new Button();
            button37 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 764);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // atras3
            // 
            atras3.BackColor = Color.Black;
            atras3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atras3.ForeColor = SystemColors.ButtonHighlight;
            atras3.Location = new Point(12, 767);
            atras3.Name = "atras3";
            atras3.Size = new Size(136, 52);
            atras3.TabIndex = 41;
            atras3.Text = "Atras";
            atras3.UseVisualStyleBackColor = false;
            atras3.Click += atras3_Click;
            // 
            // button37
            // 
            button37.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button37.Location = new Point(1140, 690);
            button37.Name = "button37";
            button37.Size = new Size(309, 62);
            button37.TabIndex = 42;
            button37.Text = "Comprar boletos";
            button37.UseVisualStyleBackColor = true;
            button37.Click += button37_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1r;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(952, 105);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(665, 529);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // Play1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1792, 831);
            Controls.Add(pictureBox2);
            Controls.Add(button37);
            Controls.Add(atras3);
            Controls.Add(pictureBox1);
            Name = "Play1";
            Text = "Play1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button atras3;
        private Button button37;
        private PictureBox pictureBox2;
    }
}