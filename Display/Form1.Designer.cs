namespace Display
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.YCbCr_btn = new System.Windows.Forms.Button();
            this.Cr_btn = new System.Windows.Forms.Button();
            this.Cb_btn = new System.Windows.Forms.Button();
            this.CbCr_btn = new System.Windows.Forms.Button();
            this.Y_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // YCbCr_btn
            // 
            this.YCbCr_btn.Location = new System.Drawing.Point(0, 400);
            this.YCbCr_btn.Name = "YCbCr_btn";
            this.YCbCr_btn.Size = new System.Drawing.Size(75, 50);
            this.YCbCr_btn.TabIndex = 1;
            this.YCbCr_btn.Text = "YCbCr";
            this.YCbCr_btn.UseVisualStyleBackColor = true;
            this.YCbCr_btn.Click += new System.EventHandler(this.YCbCr_btn_Click);
            // 
            // Cr_btn
            // 
            this.Cr_btn.Location = new System.Drawing.Point(225, 400);
            this.Cr_btn.Name = "Cr_btn";
            this.Cr_btn.Size = new System.Drawing.Size(75, 50);
            this.Cr_btn.TabIndex = 2;
            this.Cr_btn.Text = "Cr";
            this.Cr_btn.UseVisualStyleBackColor = true;
            this.Cr_btn.Click += new System.EventHandler(this.Cr_btn_Click);
            // 
            // Cb_btn
            // 
            this.Cb_btn.Location = new System.Drawing.Point(150, 400);
            this.Cb_btn.Name = "Cb_btn";
            this.Cb_btn.Size = new System.Drawing.Size(75, 50);
            this.Cb_btn.TabIndex = 3;
            this.Cb_btn.Text = "Cb";
            this.Cb_btn.UseVisualStyleBackColor = true;
            this.Cb_btn.Click += new System.EventHandler(this.Cb_btn_Click);
            // 
            // CbCr_btn
            // 
            this.CbCr_btn.Location = new System.Drawing.Point(75, 400);
            this.CbCr_btn.Name = "CbCr_btn";
            this.CbCr_btn.Size = new System.Drawing.Size(75, 50);
            this.CbCr_btn.TabIndex = 4;
            this.CbCr_btn.Text = "CbCr";
            this.CbCr_btn.UseVisualStyleBackColor = true;
            this.CbCr_btn.Click += new System.EventHandler(this.CbCr_btn_Click);
            // 
            // Y_btn
            // 
            this.Y_btn.Location = new System.Drawing.Point(300, 400);
            this.Y_btn.Name = "Y_btn";
            this.Y_btn.Size = new System.Drawing.Size(75, 50);
            this.Y_btn.TabIndex = 5;
            this.Y_btn.Text = "Y";
            this.Y_btn.UseVisualStyleBackColor = true;
            this.Y_btn.Click += new System.EventHandler(this.Y_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Y_btn);
            this.Controls.Add(this.CbCr_btn);
            this.Controls.Add(this.Cb_btn);
            this.Controls.Add(this.Cr_btn);
            this.Controls.Add(this.YCbCr_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button YCbCr_btn;
        private System.Windows.Forms.Button Cr_btn;
        private System.Windows.Forms.Button Cb_btn;
        private System.Windows.Forms.Button CbCr_btn;
        private System.Windows.Forms.Button Y_btn;
    }
}

