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
            this.YCbCrCheckboxes = new System.Windows.Forms.CheckedListBox();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.ConversionsList = new System.Windows.Forms.ListBox();
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
            // YCbCrCheckboxes
            // 
            this.YCbCrCheckboxes.CheckOnClick = true;
            this.YCbCrCheckboxes.FormattingEnabled = true;

            this.YCbCrCheckboxes.Items.AddRange(new object[] {
            "Y",
            "Cb",
            "Cr"});
            this.YCbCrCheckboxes.SetItemChecked(0, true);
            this.YCbCrCheckboxes.SetItemChecked(1, true);
            this.YCbCrCheckboxes.SetItemChecked(2, true);

            this.YCbCrCheckboxes.Location = new System.Drawing.Point(806, 0);
            this.YCbCrCheckboxes.Name = "checkedListBox1";
            this.YCbCrCheckboxes.Size = new System.Drawing.Size(60, 73);
            this.YCbCrCheckboxes.TabIndex = 6;
            this.YCbCrCheckboxes.SelectedIndexChanged += new System.EventHandler(this.YCbCrCheckboxes_SelectedIndexChanged);
            // 
            // ConversionsList
            // 
            this.ConversionsList.FormattingEnabled = true;
            this.ConversionsList.ItemHeight = 20;
            
            this.ConversionsList.Items.AddRange(new object[] {
            new ConversionConstants(299, 587, 114, "JPEG"),
            new ConversionConstants(650, 535, 445, "Wavelength"),
            new ConversionConstants(3056, 3713, 4463, "Energy"),
            new ConversionConstants(64, 32, 2, "Sensitivity"),
            new ConversionConstants(1, 1, 1, "Equal"),
            new ConversionConstants(1000, 1, 1, "Red"),
            new ConversionConstants(1, 1000, 1, "Green"),
            new ConversionConstants(1, 1, 1000, "Blue"),
            new ConversionConstants(1, 1000, 1000, "GreenBlue"),
            new ConversionConstants(1000, 1, 1000, "RedBlue"),
            new ConversionConstants(1000, 1000, 1, "RedGreen")});
            this.ConversionsList.SetSelected(0, true);

            this.ConversionsList.Location = new System.Drawing.Point(806, 79);
            this.ConversionsList.Name = "ConversionsList";
            this.ConversionsList.Size = new System.Drawing.Size(153, 321);
            this.ConversionsList.TabIndex = 8;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Location = new System.Drawing.Point(872, 0);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(87, 75);
            this.SettingsBtn.TabIndex = 7;
            this.SettingsBtn.Text = "Apply Settings";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 400);
            this.Controls.Add(this.ConversionsList);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.YCbCrCheckboxes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "YCbCrCustomDisplay";
            this.Text = "YCbCrCustomDisplay";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox YCbCrCheckboxes;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.ListBox ConversionsList;
    }
}

