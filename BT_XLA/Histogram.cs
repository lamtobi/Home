using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;



namespace BT_XLA
{
    public partial class Histogram : Form
    {
        private Bitmap originalImage;
        private int[] histogram;


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


        private int[] CalculateHistogram(Bitmap image)
        {
            int[] histogram = new int[256];

            // Tính toán histogram của hình ảnh
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int grayValue = (int)(0.2989 * pixel.R + 0.5870 * pixel.G + 0.1140 * pixel.B); // Chuyển đổi sang ảnh grayscale
                    histogram[grayValue]++;
                }
            }

            return histogram;
        }

        private void DrawHistogram()
        {
            // Tạo một Bitmap để vẽ biểu đồ
            Bitmap histogramBitmap = new Bitmap(256, 200);

            // Tạo một Graphics từ Bitmap
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                // Xóa nền của biểu đồ
                g.Clear(Color.White);

                // Vẽ các cột của biểu đồ histogram
                Pen pen = new Pen(Color.Black);
                for (int i = 0; i < histogram.Length; i++)
                {
                    int height = histogram[i];
                    g.DrawLine(pen, i, 199, i, 199 - height); // Vẽ đường thẳng từ (i, 199) đến (i, 199 - height)
                }
            }

            // Hiển thị biểu đồ histogram lên PictureBox
            pic_histogram.Image = histogramBitmap;
        }



        private void btn_vehistogram_Click(object sender, EventArgs e)
        {
            histogram = CalculateHistogram(_imgtruoc);

            pic_histogram.Image = _imgsau;
            DrawHistogram();
        }

        private void Histogram_Load(object sender, EventArgs e)
        {

        }

        private void btn_xam_Click(object sender, EventArgs e)
        {
            pic_xam.Image = Chuyenxam(_imgtruoc);
        }
    }
}
