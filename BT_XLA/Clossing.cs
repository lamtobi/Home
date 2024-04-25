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
    public partial class Clossing : Form
    {
        Bitmap _imgtruoc, _imgsau;
        public Clossing(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }

        private void Clossing_Load(object sender, EventArgs e)
        {

        }
        private void Erosion_Load(object sender, EventArgs e)
        {

        }
        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pcb_closs.Image = selectImage;
                _imgtruoc = new Bitmap(pcb_closs.Image);
                _imgsau = new Bitmap(_imgtruoc);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }

        public static Bitmap Dilation(Bitmap image, int[,] kernel)
        {
            int width = image.Width;
            int height = image.Height;

            Bitmap resultImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (image.GetPixel(x, y).ToArgb() == Color.Black.ToArgb())
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                int newX = x + i;
                                int newY = y + j;

                                if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                                {
                                    if (kernel[i + 1, j + 1] == 1)
                                    {
                                        resultImage.SetPixel(newX, newY, Color.Black);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, Color.White);
                    }
                }
            }
            return resultImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] mask =
 {{ 0, 1, 0 },
    { 1, 1, 1 },
    { 0, 1, 0 }};

            Bitmap img1 = Dilation(_imgtruoc, mask);
            Bitmap img2 = Erosion(img1, mask);

            pcb_closs.Image = img2;
            pcb_closs.Refresh();
        }

        public static Bitmap Erosion(Bitmap image, int[,] mask)
        {
            int width = image.Width;
            int height = image.Height;

            Bitmap resultImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (image.GetPixel(x, y).ToArgb() == Color.White.ToArgb())
                    {
                        bool shouldErode = true;
                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                int newX = x + i;
                                int newY = y + j;

                                if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                                {
                                    if (mask[i + 1, j + 1] == 1 && image.GetPixel(newX, newY).ToArgb() == Color.Black.ToArgb())
                                    {
                                        shouldErode = false;
                                        break;
                                    }
                                }
                            }
                            if (!shouldErode) break;
                        }

                        if (shouldErode)
                        {
                            resultImage.SetPixel(x, y, Color.White);
                        }
                        else
                        {
                            resultImage.SetPixel(x, y, Color.Black);
                        }
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, Color.Black);
                    }
                }
            }

            return resultImage;
        }


    }
}
