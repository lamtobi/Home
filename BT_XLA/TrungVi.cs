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
    public partial class TrungVi : Form
    {
        Bitmap _imgtruoc, _imgsau;

        public TrungVi(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }

        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pic_tc.Image = selectImage;
                _imgtruoc = new Bitmap(pic_tc.Image);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }


        private void btn_run_Click(object sender, EventArgs e)
        {
            pic_tc.Image = LocTrungVi(_imgtruoc, nm_nguong.Value);
            pic_tc.Refresh();
        }

        private void TrungVi_Load(object sender, EventArgs e)
        {

        }

        private Bitmap LocTrungVi(Bitmap img, decimal nguong)
        {
            _imgsau = new Bitmap(_imgtruoc.Width, _imgtruoc.Height);

            for(int x = 1; x < _imgtruoc.Width - 1; x++)
            {
                for(int y = 1; y <  _imgtruoc.Height - 1; y++)
                {
                    int[] giatrigan = new int[9];

                    int index = 0;

                    for(int i = -1;i <= 1; i++)
                    {
                        for(int j = -1; j <=1; j++)
                        {
                            Color pixelColor = _imgtruoc.GetPixel(x + i, y + j);
                            int grayValue = (int)(0.299 *  pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                            giatrigan[index++] = grayValue;
                        }
                    }

                    Array.Sort(giatrigan);
                   
                    int gtritrungbinh = giatrigan[4];
                    Color newColor = Color.FromArgb(gtritrungbinh, gtritrungbinh, gtritrungbinh);

                    _imgsau.SetPixel(x, y, newColor);
                }
            }

            return _imgsau;
        }
    }
}
