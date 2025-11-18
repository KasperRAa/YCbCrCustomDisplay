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
        const float Default_Y = 128f;
        const float Default_Cb = 0f;
        const float Default_Cr = 0f;

        private float Constant_R;
        private float Constant_G;
        private float Constant_B;

        private bool Use_Y;
        private bool Use_Cb;
        private bool Use_Cr;

        private float Factor_Y;
        private float Factor_iY;
        private float Factor_Cb;
        private float Factor_Cr;

        public YCbCr()
        {
            SetConstants(1, 1, 1);
            SetUses(true, true, true);
            SetFactors(1, 1, 1, 1);
        }

        public void SetConstants(int r, int g, int b)
        {
            float weight = r + g + b;
            Constant_R = r / weight;
            Constant_G = g / weight;
            Constant_B = b / weight;
        }
        public void SetConstants(ConversionConstants cc)
        {
            SetConstants(cc.R, cc.G, cc.B);
        }
        public void SetUses(bool y, bool cb, bool cr)
        {
            Use_Y = y;
            Use_Cb = cb;
            Use_Cr = cr;
        }
        public void SetFactors(float y, float iy, float cb, float cr)
        {
            Factor_Y = y;
            Factor_iY = iy;
            Factor_Cb = cb;
            Factor_Cr = cr;
        }

        public Color Convert(Color oldColor)
        {
            float[] ycbcr = RGB2YCbCr(oldColor);
            if (!Use_Y) ycbcr[0] = Default_Y;
            else ycbcr[0] = (Default_Y + (ycbcr[0] - Default_Y) * Factor_iY) * Factor_Y;
            if (!Use_Cb) ycbcr[1] = Default_Cb;
            else ycbcr[1] *= Factor_Cb;
            if (!Use_Cr) ycbcr[2] = Default_Cr;
            else ycbcr[2] *= Factor_Cr;
            Color newColor = YCbCr2RGB(ycbcr);
            return newColor;
        }

        private float[] MatrixMath(float[,] consts, float[] values)
        {
            float[] result = new float[3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i] += consts[j, i] * values[j];
                }
            }

            return result;
        }

        private float[] RGB2YCbCr(Color rgb)
        {
            float[] RGB = new float[3] { rgb.R, rgb.G, rgb.B };

            float[,] matrix =
            {
                { Constant_R, -0.5f * Constant_R / (1 - Constant_B), 0.5f },
                { Constant_G, -0.5f * Constant_G / (1 - Constant_B), -0.5f * Constant_G / (1 - Constant_R) },
                { Constant_B, 0.5f, -0.5f * Constant_B / (1 - Constant_R) }
            };

            float[] result = MatrixMath(matrix, RGB);

            return result;
        }
        private Color YCbCr2RGB(float[] YCbCr)
        {
            float[,] matrix =
            {
                { 1,1,1},
                { 0, - Constant_B / Constant_G * (2 - 2 * Constant_B), 2 - 2 * Constant_B },
                { 2 - 2 * Constant_R, - Constant_R / Constant_G * (2 - 2 * Constant_R), 0 }
            };

            float[] rgb = MatrixMath(matrix, YCbCr);

            for (int n = 0; n < 3; n++) rgb[n] = Math.Min(Math.Max(rgb[n], 0), 255);

            Color result = Color.FromArgb((byte)rgb[0], (byte)rgb[1], (byte)rgb[2]);

            return result;
        }
    }
}
