using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;



namespace BT_XLA
{
    public partial class Histogram : Form
    {
        

        public Histogram(string img)
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
                pic_xam.Image = selectImage;
                _imgtruoc = new Bitmap(pic_xam.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }

        private Bitmap Chuyenxam(Bitmap img)
        {
            _imgsau = new Bitmap(_imgtruoc.Width, _imgtruoc.Height);

            for(int x = 0; x < _imgtruoc.Width; x++)
            {
                for(int y = 0;  y < _imgtruoc.Height; y++)
                {
                    Color pixel = _imgtruoc.GetPixel(x, y);
                    int mauxam = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                    Color newColor = Color.FromArgb(mauxam, mauxam, mauxam);
                    _imgsau.SetPixel(x, y, newColor);
                }
            }
            return _imgsau;
        }

        public int indexOf(int hang, int cot, int stride)
        {
            return hang * stride + cot * 3;
        }
        unsafe
        public Bitmap Vehistogram(Bitmap img)
        {
            Bitmap histogram = new Bitmap(256,256,PixelFormat.Format24bppRgb);
            BitmapData data = img.LockBits(new Rectangle(0, 0, histogram.Width, histogram.Height), ImageLockMode.ReadWrite, img.PixelFormat);
            byte* p = (byte*)data.Scan0;
            int offset = data.Stride - img.Width * 3;

            int[] count = new int[256];
            int max = 0;
            for(int hang = 0; hang < img.Width; hang++)
            {
                for(int cot = 0; cot < img.Height; cot++)
                {
                    count[p[0]]++;
                    if (count[p[0]] > max)
                    {
                        max = count[p[0]];
                    }
                    p += 3;
                }
                p += offset;
            }
            img.UnlockBits(data);

            for(int i = 0; i < 256; i++)
            {
                count[i] = (int)(count[i] * (histogram.Height - 1) * 1f / max * 1f);
            }

            data = histogram.LockBits(new Rectangle(0,0,histogram.Width, histogram.Height),ImageLockMode.ReadWrite, histogram.PixelFormat);
            p = (byte*)data.Scan0;
            offset = data.Stride - histogram.Width * 3;

            for(int cot = 0; cot < histogram.Width; cot++)
            {
                for(int hang = 0; hang < histogram.Height; hang++)
                {
                    byte value = 255;
                    if(hang <= (histogram.Height - count[cot]))
                    {
                        value = 255;
                    }
                    else
                    {
                        value = 0;
                    }
                    p[indexOf(hang, cot, data.Stride)] = value;
                    p[indexOf(hang, cot, data.Stride) + 1] = value;
                    p[indexOf(hang, cot, data.Stride) + 2] = value;
                }
            }
            histogram.UnlockBits(data);
            return histogram;
        }

        private void btn_vehistogram_Click(object sender, EventArgs e)
        {
            Bitmap h = Vehistogram(_imgsau);
            pic_histogram.Image = h;
        }

        private void btn_xam_Click(object sender, EventArgs e)
        {
            pic_xam.Image = Chuyenxam(_imgtruoc);
        }
    }
}
