using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private Bitmap _originalImage;
        private YCbCr _ycbcr = new YCbCr();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YCbCrCheckboxes.Items.AddRange(new object[] {
            "Y",
            "Cb",
            "Cr"});
            YCbCrCheckboxes.SetItemChecked(0, true);
            YCbCrCheckboxes.SetItemChecked(1, true);
            YCbCrCheckboxes.SetItemChecked(2, true);

            ConversionsList.Items.AddRange(new object[] {
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
            ConversionsList.SetSelected(0, true);

            _originalImage = new Bitmap(@"C:\Users\kaspe\Desktop\YCbCrDisplay\Display\Images\Bird.bmp");
            ApplySettings();
            SetImage(_originalImage);
        }

        private void SetImage(Image image)
        {
            pictureBox1.Image = image;
        }

        private void ApplySettings()
        {
            bool y = YCbCrCheckboxes.GetItemChecked(0);
            bool cb = YCbCrCheckboxes.GetItemChecked(1);
            bool cr = YCbCrCheckboxes.GetItemChecked(2);
            _ycbcr.SetUses(y, cb, cr);

            _ycbcr.SetConstants((ConversionConstants)ConversionsList.SelectedItem);

            decimal y_factor = Y_Factor.Value;
            decimal iy_factor = iY_Factor.Value;
            decimal cb_factor = Cb_Factor.Value;
            decimal cr_factor = Cr_Factor.Value;
            _ycbcr.SetFactors((float)y_factor, (float)iy_factor, (float)cb_factor, (float)cr_factor);
        }

        private void ShowImage()
        {
            ApplySettings();
            ModifyImage(_ycbcr.Convert);
        }

        private void ModifyImage(Converter<Color, Color> converter)
        {
            int width = _originalImage.Width;
            int height = _originalImage.Height;
            Bitmap newImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color color = _originalImage.GetPixel(x, y);
                    color = converter(color);
                    newImage.SetPixel(x, y, color);
                }
            }

            SetImage(newImage);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            ShowImage();
        }
        private void YCbCrCheckboxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = YCbCrCheckboxes.SelectedIndex;
            if (index != -1) YCbCrCheckboxes.SetSelected(index, false);
        }

        private void Reset_Factors_Btn_Click(object sender, EventArgs e)
        {
            Y_Factor.Value = 1;
            iY_Factor.Value = 1;
            Cb_Factor.Value = 1;
            Cr_Factor.Value = 1;
        }
    }
}
