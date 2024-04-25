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
    public partial class prewitt : Form
    {
        Bitmap _imgtruoc, _imgsau;
        public prewitt(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }

        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pic_pre.Image = selectImage;
                _imgtruoc = new Bitmap(pic_pre.Image);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }
        private void prewitt_Load(object sender, EventArgs e)
        {
            // Kiểm tra xem PictureBox có ảnh không
            if (pic_pre.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy ảnh từ PictureBox
            Bitmap originalImage = new Bitmap(pic_pre.Image);

            // Tạo ảnh mới để lưu kết quả tách biên
            Bitmap edgeImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Áp dụng Prewitt Operator để phát hiện cạnh
            for (int y = 1; y < originalImage.Height - 1; y++)
            {
                for (int x = 1; x < originalImage.Width - 1; x++)
                {
                    int gx = ((originalImage.GetPixel(x - 1, y - 1).R + originalImage.GetPixel(x - 1, y).R + originalImage.GetPixel(x - 1, y + 1).R)
                            - (originalImage.GetPixel(x + 1, y - 1).R + originalImage.GetPixel(x + 1, y).R + originalImage.GetPixel(x + 1, y + 1).R));

                    int gy = ((originalImage.GetPixel(x - 1, y - 1).R + originalImage.GetPixel(x, y - 1).R + originalImage.GetPixel(x + 1, y - 1).R)
                            - (originalImage.GetPixel(x - 1, y + 1).R + originalImage.GetPixel(x, y + 1).R + originalImage.GetPixel(x + 1, y + 1).R));

                    int gradient = (int)Math.Sqrt(gx * gx + gy * gy);

                    if (gradient > 255)
                        gradient = 255;
                    else if (gradient < 0)
                        gradient = 0;

                    edgeImage.SetPixel(x, y, Color.FromArgb(gradient, gradient, gradient));
                }
            }

            // Hiển thị ảnh đã được tách biên lên PictureBox
            pic_pre.Image = edgeImage;
        }
    }
}
