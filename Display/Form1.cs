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
    }
}
