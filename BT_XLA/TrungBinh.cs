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
    public partial class TrungBinh : Form
    {
        public TrungBinh(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }
        Bitmap _imgtruoc, _imgsau;

        

        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pic_tb.Image = selectImage;
                _imgtruoc = new Bitmap(pic_tb.Image);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            pic_tb.Image = LocTrungVi(_imgtruoc, nm_nguong.Value);
            pic_tb.Refresh();
        }

        private Bitmap LocTrungVi(Bitmap img, decimal nguong)
        {
            _imgsau = new Bitmap(_imgtruoc.Width, _imgtruoc.Height);

            for (int x = 1; x < _imgtruoc.Width - 1; x++)
            {
                for (int y = 1; y < _imgtruoc.Height - 1; y++)
                {
                    int sum = 0;

                    int index = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixelColor = _imgtruoc.GetPixel(x + i, y + j);
                            int grayValue = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                            sum += grayValue;
                        }
                    }

                    

                    int gtritrungbinh = sum /9;
                    Color newColor = Color.FromArgb(gtritrungbinh, gtritrungbinh, gtritrungbinh);

                    _imgsau.SetPixel(x, y, newColor);
                }
            }

            return _imgsau;
        }
    }
}
