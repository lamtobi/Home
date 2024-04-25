using System;
using System.Drawing;
using System.Windows.Forms;

namespace BT_XLA
{
    public partial class DoSang : Form
    {
        Bitmap _imgsau;
        Bitmap _imgtruoc;


        public DoSang(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);

        }

        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pb_dosang.Image = selectImage;
                _imgtruoc = new Bitmap(pb_dosang.Image);
                _imgsau = new Bitmap(_imgtruoc);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }


        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

            lb_C.Text = trb_C.Value.ToString();

            int c = trb_C.Value;

            if(_imgtruoc == null)
            {
                return;
            }
            
            Color color1, color2;
            for (int x = 0; x < _imgtruoc.Width; x++)
                for (int y = 0; y < _imgtruoc.Height; y++)
                {
                    color1 = _imgtruoc.GetPixel(x, y);
                    if (color1.R + c > 255)
                        color2 = Color.FromArgb(255, 255, 255);
                    else if (color1.R + c < 0)
                        color2 = Color.FromArgb(0, 0, 0);
                    else
                        color2 = Color.FromArgb(color1.R + c, color1.R + c, color1.R + c);
                    
                    _imgsau.SetPixel(x, y, color2);
                }
            pb_dosang.Image = _imgsau;
            pb_dosang.Refresh();
        }

        private void DoSang_Load(object sender, EventArgs e)
        {

        }

        private void trb_C_Scroll(object sender, EventArgs e)
        {

        }

        private void lb_C_Click(object sender, EventArgs e)
        {

        }
    }
}
