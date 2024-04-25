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
    public partial class laplace : Form
    {
        Bitmap _imgtruoc, _imgsau;
        public laplace(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }
        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pic_lap.Image = selectImage;
                _imgtruoc = new Bitmap(pic_lap.Image);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem PictureBox có ảnh không
            if (pic_lap.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy ảnh từ PictureBox
            Bitmap originalImage = new Bitmap(pic_lap.Image);

            // Tạo ảnh mới để lưu kết quả tách biên
            Bitmap edgeImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Áp dụng toán tử Laplace để phát hiện cạnh
            int[,] laplacianKernel = new int[,]
            {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 }
            };

            Decimal threshold = nm_nguong.Value; // Ngưỡng để phân loại cạnh

            for (int y = 1; y < originalImage.Height - 1; y++)
            {
                for (int x = 1; x < originalImage.Width - 1; x++)
                {
                    int sum = 0;
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color pixel = originalImage.GetPixel(x + kx, y + ky);
                            int grayValue = (int)(0.2989 * pixel.R + 0.5870 * pixel.G + 0.1140 * pixel.B); // Chuyển đổi sang ảnh grayscale
                            sum += laplacianKernel[ky + 1, kx + 1] * grayValue;
                        }
                    }

                    int gradient = Math.Abs(sum);
                    if (gradient > threshold)
                        edgeImage.SetPixel(x, y, Color.White); // Đánh dấu là cạnh
                    else
                        edgeImage.SetPixel(x, y, Color.Black); // Không phải cạnh
                }
            }

            // Hiển thị ảnh đã được tách biên lên PictureBox
            pic_lap.Image = edgeImage;
        }

        private void laplace_Load(object sender, EventArgs e)
        {
           
        }
    }
}
