using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;

namespace BT_XLA
{
    public partial class TachNguong_TuDong : Form
    {
        Bitmap _imgtruoc, _imgsau;
        public TachNguong_TuDong(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }

        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pic_tu.Image = selectImage;
                _imgtruoc = new Bitmap(pic_tu.Image);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap result = new Bitmap(_imgtruoc.Width, _imgtruoc.Height);

            // Tính toán histogram của hình ảnh
            int[] histogram = new int[256];
            for (int y = 0; y < _imgtruoc.Height; y++)
            {
                for (int x = 0; x < _imgtruoc.Width; x++)
                {
                    Color pixel = _imgtruoc.GetPixel(x, y);
                    int grayValue = (int)(0.2989 * pixel.R + 0.5870 * pixel.G + 0.1140 * pixel.B); // Chuyển đổi sang ảnh grayscale
                    histogram[grayValue]++;
                }
            }

            // Tính toán tổng số điểm ảnh
            int totalPixels = _imgtruoc.Width * _imgtruoc.Height;

            // Tính toán ngưỡng tách ngưỡng tự động bằng phương pháp Otsu
            int threshold = 0;
            double maxVarBetweenClasses = 0.0;

            for (int t = 0; t < 256; t++)
            {
                int sumBack = 0;
                int sumFore = 0;
                int countBack = 0;
                int countFore = 0;

                for (int i = 0; i < 256; i++)
                {
                    if (i <= t)
                    {
                        sumBack += i * histogram[i];
                        countBack += histogram[i];
                    }
                    else
                    {
                        sumFore += i * histogram[i];
                        countFore += histogram[i];
                    }
                }

                double probBack = countBack / (double)totalPixels;
                double probFore = countFore / (double)totalPixels;
                double meanBack = countBack == 0 ? 0 : sumBack / (double)countBack;
                double meanFore = countFore == 0 ? 0 : sumFore / (double)countFore;

                double varBetweenClasses = probBack * probFore * Math.Pow(meanBack - meanFore, 2);
                if (varBetweenClasses > maxVarBetweenClasses)
                {
                    maxVarBetweenClasses = varBetweenClasses;
                    threshold = t;
                }
            }

            // Áp dụng ngưỡng tách ngưỡng tự động cho từng điểm ảnh trong hình ảnh
            for (int y = 0; y < _imgtruoc.Height; y++)
            {
                for (int x = 0; x < _imgtruoc.Width; x++)
                {
                    Color pixel = _imgtruoc.GetPixel(x, y);
                    int grayValue = (int)(0.2989 * pixel.R + 0.5870 * pixel.G + 0.1140 * pixel.B); // Chuyển đổi sang ảnh grayscale

                    if (grayValue >= threshold)
                        result.SetPixel(x, y, Color.White); // Đánh dấu là điểm ảnh trắng
                    else
                        result.SetPixel(x, y, Color.Black); // Đánh dấu là điểm ảnh đen
                }
            }

            pic_tu.Image = result;
        }

        private void TachNguong_TuDong_Load(object sender, EventArgs e)
        {
          
        }

    
    }
}
