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
    public partial class laplace : Form
    {
        Bitmap _imgtruoc, _imgsau;
        public laplace(string img)
        {
            InitializeComponent();
            ShowSelectImg(img);
        }
        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pic_lap.Image = selectImage;
                _imgtruoc = new Bitmap(pic_lap.Image);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }
        private void laplace_Load(object sender, EventArgs e)
        {

        }
    }
}
