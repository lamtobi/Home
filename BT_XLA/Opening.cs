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
    public partial class Opening : Form
    {
        Bitmap _imgtruoc, _imgsau;
        public Opening(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }

        private void Erosion_Load(object sender, EventArgs e)
        {

        }
        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pcb_open.Image = selectImage;
                _imgtruoc = new Bitmap(pcb_open.Image);
                _imgsau = new Bitmap(_imgtruoc);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap openedImage = PerformOpening(_imgsau);
            pcb_open.Image = openedImage;
        }

        private void Opening_Load(object sender, EventArgs e)
        {

        }

        private Bitmap PerformOpening(Image originalImage)
        {
            // Khởi tạo hình ảnh opened
            Bitmap openedImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Gán màu trắng cho tất cả các pixel trong hình ảnh
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    openedImage.SetPixel(x, y, Color.White);
                }
            }

            // Thực hiện erosion trước
            Bitmap erodedImage = PerformErosion(originalImage);

            // Sau đó, thực hiện dilation trên kết quả erosion
            openedImage = PerformDilation(erodedImage);

            return openedImage;
        }

        private Bitmap PerformErosion(Image originalImage)
        {
            // Khởi tạo hình ảnh erosion
            Bitmap erodedImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Ma trận kết cấu (structuring element) cho erosion
            int[,] structuringElement = {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            };

            // Lặp qua từng pixel trong hình ảnh gốc
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    // Kiểm tra xem tất cả các pixel lân cận có giá trị trắng không
                    bool allWhite = true;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int newX = x + j;
                            int newY = y + i;

                            // Đảm bảo không vượt ra khỏi biên của hình ảnh
                            if (newX >= 0 && newX < originalImage.Width && newY >= 0 && newY < originalImage.Height)
                            {
                                Color pixelColor = ((Bitmap)originalImage).GetPixel(newX, newY);
                                if (pixelColor.GetBrightness() < 0.5) // Kiểm tra pixel có là điểm sáng hay không
                                {
                                    allWhite = false;
                                    break;
                                }
                            }
                        }
                        if (!allWhite)
                            break;
                    }

                    // Nếu tất cả các pixel lân cận đều là điểm sáng, gán giá trị trắng cho pixel
                    if (allWhite)
                    {
                        erodedImage.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        erodedImage.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return erodedImage;
        }

        private Bitmap PerformDilation(Image originalImage)
        {
            // Khởi tạo hình ảnh dilation
            Bitmap dilatedImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Ma trận kết cấu (structuring element) cho dilation
            int[,] structuringElement = {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            };

            // Lặp qua từng pixel trong hình ảnh gốc
            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    // Nếu pixel là điểm sáng (trắng)
                    if (IsBrightPixel(originalImage, x, y))
                    {
                        // Duyệt qua cấu trúc kết cấu và gán giá trị trắng cho các pixel kết nối
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                int newX = x + j;
                                int newY = y + i;

                                // Đảm bảo không vượt ra khỏi biên của hình ảnh
                                if (newX >= 0 && newX < originalImage.Width && newY >= 0 && newY < originalImage.Height)
                                {
                                    // Nếu có kết nối với cấu trúc kết cấu
                                    if (structuringElement[i + 1, j + 1] == 1)
                                    {
                                        dilatedImage.SetPixel(newX, newY, Color.White);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return dilatedImage;
        }

        private bool IsBrightPixel(Image image, int x, int y)
        {
            // Kiểm tra xem pixel có phải là điểm sáng hay không
            Color pixelColor = ((Bitmap)image).GetPixel(x, y);
            return pixelColor.GetBrightness() > 0.5; // Kiểm tra độ sáng (0.0 - 1.0), điểm sáng nếu > 0.5
        }

    }
}
