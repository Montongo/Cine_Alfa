﻿namespace Cine_Alfa.Peliculas
{
    partial class Play4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play4));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button37 = new Button();
            atras3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5;
            pictureBox1.Location = new Point(51, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 749);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._4r;
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(848, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(785, 498);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // button37
            // 
            button37.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button37.Location = new Point(1059, 643);
            button37.Name = "button37";
            button37.Size = new Size(309, 62);
            button37.TabIndex = 50;
            button37.Text = "Comprar boletos";
            button37.UseVisualStyleBackColor = true;
            button37.Click += button37_Click;
            // 
            // atras3
            // 
            atras3.BackColor = Color.Black;
            atras3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            atras3.ForeColor = SystemColors.ButtonHighlight;
            atras3.Location = new Point(30, 747);
            atras3.Name = "atras3";
            atras3.Size = new Size(136, 52);
            atras3.TabIndex = 51;
            atras3.Text = "Atras";
            atras3.UseVisualStyleBackColor = false;
            atras3.Click += atras3_Click;
            // 
            // Play4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FON;
            ClientSize = new Size(1792, 831);
            Controls.Add(atras3);
            Controls.Add(button37);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Play4";
            Text = "Play4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button37;
        private Button atras3;
    }
}