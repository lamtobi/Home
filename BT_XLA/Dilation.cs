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
    public partial class Dilation : Form
    {
        Bitmap _imgtruoc, _imgsau;
        public Dilation(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }

        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pic_GIANNO.Image = selectImage;
                _imgtruoc = new Bitmap(pic_GIANNO.Image);
                _imgsau = new Bitmap(_imgtruoc);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }
        private void Dilation_Load(object sender, EventArgs e)
        {


        }


        private Bitmap Dilations(Bitmap image, int[,] kernel)
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

            int[,] kernel =
            {{ 1, 1, 1 },
            { 1, 1, 1 },
            { 1, 1, 1 }};

            Bitmap anhketqua = Dilations(_imgsau, kernel);
            pic_GIANNO.Image = anhketqua;
            pic_GIANNO.Refresh();
        }

     


    }
}
