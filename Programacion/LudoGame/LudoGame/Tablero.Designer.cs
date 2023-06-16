namespace LudoGame
{
    partial class Tablero
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
            this.lblJ1 = new System.Windows.Forms.Label();
            this.lblJ2 = new System.Windows.Forms.Label();
            this.lblJ3 = new System.Windows.Forms.Label();
            this.lblJ4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJ1
            // 
            this.lblJ1.AutoSize = true;
            this.lblJ1.BackColor = System.Drawing.Color.White;
            this.lblJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ1.ForeColor = System.Drawing.Color.Red;
            this.lblJ1.Location = new System.Drawing.Point(75, 73);
            this.lblJ1.Name = "lblJ1";
            this.lblJ1.Size = new System.Drawing.Size(25, 17);
            this.lblJ1.TabIndex = 2;
            this.lblJ1.Text = "J1";
            // 
            // lblJ2
            // 
            this.lblJ2.AutoSize = true;
            this.lblJ2.BackColor = System.Drawing.Color.White;
            this.lblJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ2.ForeColor = System.Drawing.Color.Green;
            this.lblJ2.Location = new System.Drawing.Point(315, 73);
            this.lblJ2.Name = "lblJ2";
            this.lblJ2.Size = new System.Drawing.Size(25, 17);
            this.lblJ2.TabIndex = 3;
            this.lblJ2.Text = "J2";
            this.lblJ2.Click += new System.EventHandler(this.lblJ2_Click);
            // 
            // lblJ3
            // 
            this.lblJ3.AutoSize = true;
            this.lblJ3.BackColor = System.Drawing.Color.White;
            this.lblJ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblJ3.Location = new System.Drawing.Point(75, 318);
            this.lblJ3.Name = "lblJ3";
            this.lblJ3.Size = new System.Drawing.Size(25, 17);
            this.lblJ3.TabIndex = 4;
            this.lblJ3.Text = "J3";
            // 
            // lblJ4
            // 
            this.lblJ4.AutoSize = true;
            this.lblJ4.BackColor = System.Drawing.Color.White;
            this.lblJ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ4.ForeColor = System.Drawing.Color.Yellow;
            this.lblJ4.Location = new System.Drawing.Point(317, 320);
            this.lblJ4.Name = "lblJ4";
            this.lblJ4.Size = new System.Drawing.Size(25, 17);
            this.lblJ4.TabIndex = 5;
            this.lblJ4.Text = "J4";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LudoGame.Properties.Resources.D6;
            this.pictureBox2.Location = new System.Drawing.Point(189, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LudoGame.Properties.Resources.LudoBoard;
            this.pictureBox1.Location = new System.Drawing.Point(7, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 407);
            this.Controls.Add(this.lblJ4);
            this.Controls.Add(this.lblJ3);
            this.Controls.Add(this.lblJ2);
            this.Controls.Add(this.lblJ1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Tablero";
            this.Text = "Tablero";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblJ1;
        private System.Windows.Forms.Label lblJ2;
        private System.Windows.Forms.Label lblJ3;
        private System.Windows.Forms.Label lblJ4;
    }
}