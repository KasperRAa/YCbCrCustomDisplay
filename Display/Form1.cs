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
        Bitmap _originalImage;
        YCbCr _ycbcr = new YCbCr(3, 6, 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _originalImage = new Bitmap(@"C:\Users\kaspe\Desktop\YCbCrDisplay\Display\Images\Bird.bmp");
            SetImage(_originalImage);
        }

        private void SetImage(Image image)
        {
            pictureBox1.Image = image;
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

        private void YCbCr_btn_Click(object sender, EventArgs e)
        {
            SetImage(_originalImage);
        }

        private void CbCr_btn_Click(object sender, EventArgs e)
        {
            ModifyImage(_ycbcr.GetConverter_CbCr());
        }

        private void Cb_btn_Click(object sender, EventArgs e)
        {
            ModifyImage(_ycbcr.GetConverter_Cb());
        }

        private void Cr_btn_Click(object sender, EventArgs e)
        {
            ModifyImage(_ycbcr.GetConverter_Cr());
        }

        private void Y_btn_Click(object sender, EventArgs e)
        {
            ModifyImage(_ycbcr.GetConverter_Y());
        }
    }
}
