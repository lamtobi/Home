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
    public partial class TachNguong_ThuCong : Form
    {
        Bitmap _imgtruoc, _imgsau;
        public TachNguong_ThuCong(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }

        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pic_thu.Image = selectImage;
                _imgtruoc = new Bitmap(pic_thu.Image);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }
        private void TachNguong_ThuCong_Load(object sender, EventArgs e)
        {
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            // Áp dụng thuật toán Thresholding và cập nhật hình ảnh
            Decimal thresholdValue = nm_nguong.Value; // Giá trị ngưỡng
            Bitmap thresholdedImage = ApplyThresholding(_imgtruoc, thresholdValue);

            // Hiển thị hình ảnh đã được xử lý lên PictureBox
            pic_thu.Image = thresholdedImage;
        }

        private Bitmap ApplyThresholding(Bitmap image, Decimal thresholdValue)
        {
            Bitmap result = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int grayValue = (int)(0.2989 * pixel.R + 0.5870 * pixel.G + 0.1140 * pixel.B); // Chuyển đổi sang ảnh grayscale

                    if (grayValue >= thresholdValue)
                        result.SetPixel(x, y, Color.White); // Đánh dấu là điểm ảnh trắng
                    else
                        result.SetPixel(x, y, Color.Black); // Đánh dấu là điểm ảnh đen
                }
            }

            return result;
        }


    }
}
