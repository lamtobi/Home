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
    public partial class LammanhBien : Form
    {
        Bitmap _imgtruoc, _imgsau;
        public LammanhBien(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }

        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pic_manhbien.Image = selectImage;
                _imgtruoc = new Bitmap(pic_manhbien.Image);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }



        private Bitmap DetectEdges(Image originalImage)
        {
            // Ma trận mẫu Sobel dùng cho phát hiện biên
            int[,] sobelMatrixX = { { -1, 0, 1 },
                                    { -2, 0, 2 },
                                    { -1, 0, 1 } };

            int[,] sobelMatrixY = { { -1, -2, -1 },
                                    { 0, 0, 0 },
                                    { 1, 2, 1 } };

            Bitmap edgeImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Lặp qua từng pixel trong hình ảnh
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    // Tính toán độ dốc theo x và y
                    int gradientX = 0;
                    int gradientY = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int offsetX = x + i;
                            int offsetY = y + j;
                            if (offsetX >= 0 && offsetX < originalImage.Width && offsetY >= 0 && offsetY < originalImage.Height)
                            {
                                Color pixelColor = ((Bitmap)originalImage).GetPixel(offsetX, offsetY);
                                int grayValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11); // Chuyển đổi sang ảnh xám
                                gradientX += sobelMatrixX[i + 1, j + 1] * grayValue;
                                gradientY += sobelMatrixY[i + 1, j + 1] * grayValue;
                            }
                        }
                    }

                    // Tính toán giá trị biên
                    int edgeValue = Math.Abs(gradientX) + Math.Abs(gradientY);
                    edgeValue = Math.Min(255, edgeValue); // Giới hạn giá trị biên trong khoảng 0-255

                    // Gán giá trị biên cho pixel tại vị trí (x, y)
                    edgeImage.SetPixel(x, y, Color.FromArgb(edgeValue, edgeValue, edgeValue));
                }
            }

            return edgeImage;
        }
            private void LammanhBien_Load(object sender, EventArgs e)
        {
            Image edgeImage = DetectEdges(_imgtruoc);
            pic_manhbien.Image = edgeImage;
        }
    }
}
