using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_XLA
{
    public partial class Gradien : Form
    {
        Bitmap _imgtruoc, _imgsau;
        public Gradien(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }
        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pic_gra.Image = selectImage;
                _imgtruoc = new Bitmap(pic_gra.Image);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }
        private void Gradien_Load(object sender, EventArgs e)
        {
            Bitmap result = new Bitmap(pic_gra.Width, pic_gra.Height);

            // Ma trận gradient Sobel
            int[,] sobelX = {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            };

            int[,] sobelY = {
                { -1, -2, -1 },
                { 0, 0, 0 },
                { 1, 2, 1 }
            };

            // Ngưỡng để phân loại cạnh
            int threshold = 50;

            for (int y = 1; y < _imgtruoc.Height - 1; y++)
            {
                for (int x = 1; x < _imgtruoc.Width - 1; x++)
                {
                    int sumX = 0;
                    int sumY = 0;

                    // Tính toán gradient theo hướng X
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color pixel = _imgtruoc.GetPixel(x + kx, y + ky);
                            int grayValue = (int)(0.2989 * pixel.R + 0.5870 * pixel.G + 0.1140 * pixel.B); // Chuyển đổi sang ảnh grayscale
                            sumX += sobelX[ky + 1, kx + 1] * grayValue;
                            sumY += sobelY[ky + 1, kx + 1] * grayValue;
                        }
                    }

                    // Tính toán độ lớn gradient
                    int gradient = (int)Math.Sqrt(sumX * sumX + sumY * sumY);

                    // Kiểm tra ngưỡng để phân loại cạnh
                    if (gradient > threshold)
                        result.SetPixel(x, y, Color.White); // Đánh dấu là cạnh
                    else
                        result.SetPixel(x, y, Color.Black); // Không phải cạnh
                }
            }

            pic_gra.Image = result;
        }
    }
}
