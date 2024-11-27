namespace Cine_Alfa.Peliculas
{
    partial class Play3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play3));
            atras3 = new Button();
            button37 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // atras3
            // 
            atras3.BackColor = Color.Black;
            atras3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atras3.ForeColor = SystemColors.ButtonHighlight;
            atras3.Location = new Point(115, 750);
            atras3.Name = "atras3";
            atras3.Size = new Size(136, 52);
            atras3.TabIndex = 50;
            atras3.Text = "Atras";
            atras3.UseVisualStyleBackColor = false;
            atras3.Click += atras3_Click;
            // 
            // button37
            // 
            button37.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button37.Location = new Point(1106, 640);
            button37.Name = "button37";
            button37.Size = new Size(309, 62);
            button37.TabIndex = 49;
            button37.Text = "Comprar boletos";
            button37.UseVisualStyleBackColor = true;
            button37.Click += button37_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._3r;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(768, 88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(909, 473);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4;
            pictureBox1.Location = new Point(131, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 726);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // Play3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FON;
            ClientSize = new Size(1792, 831);
            Controls.Add(atras3);
            Controls.Add(button37);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Play3";
            Text = "Play3";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button atras3;
        private Button button37;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}