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
            this.Y_Factor = new System.Windows.Forms.NumericUpDown();
            this.Y_Factor_Box = new System.Windows.Forms.TextBox();
            this.iY_Factor_Box = new System.Windows.Forms.TextBox();
            this.iY_Factor = new System.Windows.Forms.NumericUpDown();
            this.Cb_Factor_Box = new System.Windows.Forms.TextBox();
            this.Cb_Factor = new System.Windows.Forms.NumericUpDown();
            this.Cr_Factor_Box = new System.Windows.Forms.TextBox();
            this.Cr_Factor = new System.Windows.Forms.NumericUpDown();
            this.Reset_Factors_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_Factor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iY_Factor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cb_Factor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cr_Factor)).BeginInit();
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
            this.YCbCrCheckboxes.Location = new System.Drawing.Point(806, 0);
            this.YCbCrCheckboxes.Name = "YCbCrCheckboxes";
            this.YCbCrCheckboxes.Size = new System.Drawing.Size(60, 73);
            this.YCbCrCheckboxes.TabIndex = 6;
            this.YCbCrCheckboxes.SelectedIndexChanged += new System.EventHandler(this.YCbCrCheckboxes_SelectedIndexChanged);
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
            // ConversionsList
            // 
            this.ConversionsList.FormattingEnabled = true;
            this.ConversionsList.ItemHeight = 20;
            this.ConversionsList.Location = new System.Drawing.Point(806, 79);
            this.ConversionsList.Name = "ConversionsList";
            this.ConversionsList.Size = new System.Drawing.Size(153, 104);
            this.ConversionsList.TabIndex = 8;
            // 
            // Y_Factor
            // 
            this.Y_Factor.DecimalPlaces = 2;
            this.Y_Factor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Y_Factor.Location = new System.Drawing.Point(806, 189);
            this.Y_Factor.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Y_Factor.Name = "Y_Factor";
            this.Y_Factor.Size = new System.Drawing.Size(70, 26);
            this.Y_Factor.TabIndex = 9;
            this.Y_Factor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Y_Factor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Y_Factor_Box
            // 
            this.Y_Factor_Box.Location = new System.Drawing.Point(882, 189);
            this.Y_Factor_Box.Name = "Y_Factor_Box";
            this.Y_Factor_Box.ReadOnly = true;
            this.Y_Factor_Box.Size = new System.Drawing.Size(77, 26);
            this.Y_Factor_Box.TabIndex = 10;
            this.Y_Factor_Box.Text = "Y: [0;2]";
            // 
            // iY_Factor_Box
            // 
            this.iY_Factor_Box.Location = new System.Drawing.Point(882, 221);
            this.iY_Factor_Box.Name = "iY_Factor_Box";
            this.iY_Factor_Box.ReadOnly = true;
            this.iY_Factor_Box.Size = new System.Drawing.Size(77, 26);
            this.iY_Factor_Box.TabIndex = 12;
            this.iY_Factor_Box.Text = "iY: [-1;1]";
            // 
            // iY_Factor
            // 
            this.iY_Factor.DecimalPlaces = 2;
            this.iY_Factor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.iY_Factor.Location = new System.Drawing.Point(806, 221);
            this.iY_Factor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iY_Factor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.iY_Factor.Name = "iY_Factor";
            this.iY_Factor.Size = new System.Drawing.Size(70, 26);
            this.iY_Factor.TabIndex = 11;
            this.iY_Factor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.iY_Factor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cb_Factor_Box
            // 
            this.Cb_Factor_Box.Location = new System.Drawing.Point(882, 253);
            this.Cb_Factor_Box.Name = "Cb_Factor_Box";
            this.Cb_Factor_Box.ReadOnly = true;
            this.Cb_Factor_Box.Size = new System.Drawing.Size(77, 26);
            this.Cb_Factor_Box.TabIndex = 14;
            this.Cb_Factor_Box.Text = "Cb: [-2;2]";
            // 
            // Cb_Factor
            // 
            this.Cb_Factor.DecimalPlaces = 2;
            this.Cb_Factor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Cb_Factor.Location = new System.Drawing.Point(806, 253);
            this.Cb_Factor.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Cb_Factor.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.Cb_Factor.Name = "Cb_Factor";
            this.Cb_Factor.Size = new System.Drawing.Size(70, 26);
            this.Cb_Factor.TabIndex = 13;
            this.Cb_Factor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Cb_Factor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cr_Factor_Box
            // 
            this.Cr_Factor_Box.Location = new System.Drawing.Point(882, 285);
            this.Cr_Factor_Box.Name = "Cr_Factor_Box";
            this.Cr_Factor_Box.ReadOnly = true;
            this.Cr_Factor_Box.Size = new System.Drawing.Size(77, 26);
            this.Cr_Factor_Box.TabIndex = 16;
            this.Cr_Factor_Box.Text = "Cr: [-2;2]";
            // 
            // Cr_Factor
            // 
            this.Cr_Factor.DecimalPlaces = 2;
            this.Cr_Factor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Cr_Factor.Location = new System.Drawing.Point(806, 285);
            this.Cr_Factor.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Cr_Factor.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.Cr_Factor.Name = "Cr_Factor";
            this.Cr_Factor.Size = new System.Drawing.Size(70, 26);
            this.Cr_Factor.TabIndex = 15;
            this.Cr_Factor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Cr_Factor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Reset_Factors_Btn
            // 
            this.Reset_Factors_Btn.Location = new System.Drawing.Point(806, 317);
            this.Reset_Factors_Btn.Name = "Reset_Factors_Btn";
            this.Reset_Factors_Btn.Size = new System.Drawing.Size(153, 83);
            this.Reset_Factors_Btn.TabIndex = 17;
            this.Reset_Factors_Btn.Text = "Reset Factors";
            this.Reset_Factors_Btn.UseVisualStyleBackColor = true;
            this.Reset_Factors_Btn.Click += new System.EventHandler(this.Reset_Factors_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 400);
            this.Controls.Add(this.Reset_Factors_Btn);
            this.Controls.Add(this.Cr_Factor_Box);
            this.Controls.Add(this.Cr_Factor);
            this.Controls.Add(this.Cb_Factor_Box);
            this.Controls.Add(this.Cb_Factor);
            this.Controls.Add(this.iY_Factor_Box);
            this.Controls.Add(this.iY_Factor);
            this.Controls.Add(this.Y_Factor_Box);
            this.Controls.Add(this.Y_Factor);
            this.Controls.Add(this.ConversionsList);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.YCbCrCheckboxes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "YCbCrCustomDisplay";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_Factor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iY_Factor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cb_Factor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cr_Factor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox YCbCrCheckboxes;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.ListBox ConversionsList;
        private System.Windows.Forms.NumericUpDown Y_Factor;
        private System.Windows.Forms.TextBox Y_Factor_Box;
        private System.Windows.Forms.TextBox iY_Factor_Box;
        private System.Windows.Forms.NumericUpDown iY_Factor;
        private System.Windows.Forms.TextBox Cb_Factor_Box;
        private System.Windows.Forms.NumericUpDown Cb_Factor;
        private System.Windows.Forms.TextBox Cr_Factor_Box;
        private System.Windows.Forms.NumericUpDown Cr_Factor;
        private System.Windows.Forms.Button Reset_Factors_Btn;
    }
}

