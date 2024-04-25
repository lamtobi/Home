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
    public partial class Erosion : Form
    {
        Bitmap _imgtruoc, _imgsau;
        public Erosion(string img)
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
                pic_Ero.Image = selectImage;
                _imgtruoc = new Bitmap(pic_Ero.Image);
                _imgsau = new Bitmap(_imgtruoc);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] kernel =
            {{ 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }};

            Bitmap anhketqua = Erosions(_imgsau, kernel);
            pic_Ero.Image = anhketqua;
            pic_Ero.Refresh();
        }

        static Bitmap Erosions(Bitmap image, int[,] kernel)
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
                                    if (kernel[i + 1, j + 1] == 1 && image.GetPixel(newX, newY).ToArgb() == Color.Black.ToArgb())
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
