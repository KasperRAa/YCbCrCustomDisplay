using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
    internal class YCbCr
    {
        const float K_Y = 128f;
        const float K_Cb = 0f;
        const float K_Cr = 0f;

        private float K_R;
        private float K_G;
        private float K_B;

        private bool B_Y;
        private bool B_Cb;
        private bool B_Cr;

        public YCbCr()
        {
            float weight = 3;
            K_R = 1 / weight;
            K_G = 1 / weight;
            K_B = 1 / weight;
            B_Y = true;
            B_Cb = true;
            B_Cr = true;
        }

        public void SetConstants(int r, int g, int b)
        {
            float weight = r + g + b;
            K_R = r / weight;
            K_G = g / weight;
            K_B = b / weight;
        }
        public void SetConstants(ConversionConstants cc)
        {
            SetConstants(cc.R, cc.G, cc.B);
        }
        public void SetUses(bool y, bool cb, bool cr)
        {
            B_Y = y;
            B_Cb = cb;
            B_Cr = cr;
        }

        public Color Convert(Color oldColor)
        {
            float[] ycbcr = RGB2YCbCr(oldColor);
            if (!B_Y) ycbcr[0] = K_Y;
            if (!B_Cb) ycbcr[1] = K_Cb;
            if (!B_Cr) ycbcr[2] = K_Cr;
            Color newColor = YCbCr2RGB(ycbcr);
            return newColor;
        }

        private float[] MatrixMath(float[,] constans, float[] values)
        {
            float[] result = new float[3];

            for (int i = 0; i < 3; i++)
            {
                result[i] = 0;
                for (int j = 0; j < 3; j++)
                {
                    result[i] += constans[j, i] * values[j];
                }
            }

            return result;
        }

        private float[] RGB2YCbCr(Color rgb)
        {
            float[] RGB = new float[3] { rgb.R, rgb.G, rgb.B };

            float[,] matrix =
            {
                { K_R, -0.5f * K_R / (1 - K_B), 0.5f },
                { K_G, -0.5f * K_G / (1 - K_B), -0.5f * K_G / (1 - K_R) },
                { K_B, 0.5f, -0.5f * K_B / (1 - K_R) }
            };

            float[] result = MatrixMath(matrix, RGB);

            return result;
        }
        private Color YCbCr2RGB(float[] YCbCr)
        {
            float[,] matrix =
            {
                { 1,1,1},
                { 0, - K_B / K_G * (2 - 2 * K_B), 2 - 2 * K_B },
                { 2 - 2 * K_R, - K_R / K_G * (2 - 2 * K_R), 0 }
            };

            float[] rgb = MatrixMath(matrix, YCbCr);

            for (int n = 0; n < 3; n++) rgb[n] = Math.Min(Math.Max(rgb[n], 0), 255);

            Color result = Color.FromArgb((byte)rgb[0], (byte)rgb[1], (byte)rgb[2]);

            return result;
        }
    }
}
