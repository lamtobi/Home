using System;
using System.Drawing;
using System.Windows.Forms;

namespace BT_XLA
{
    public partial class OpenFile : Form
    {
        public OpenFile(string img)
        {

            InitializeComponent();
            ShowSelectImg(img);
        }

        private void ShowSelectImg(string img)
        {
            try
            {
                Image selectImage = Image.FromFile(img);
                pic_goc.Image = selectImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hiển thị ảnh");
            }
        }
    }
}
