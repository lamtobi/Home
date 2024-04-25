using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace BT_XLA
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void mởFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgfile = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap files |*.bmp| JPEG files |*.jpg| PNG files |*.PNG";

            if(openFileDialog.ShowDialog() == DialogResult.OK ) 
            { 
                OpenFile F = new OpenFile(openFileDialog.FileName);
                F.MdiParent = this;
                F.Show();
            }
        }


        private void tăngGiảmĐộSángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoSang F = new DoSang(openFileDialog.FileName);
            F.MdiParent = this;
            F.Show();
        }

        private void thủCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TachNguong_ThuCong tach = new TachNguong_ThuCong(openFileDialog.FileName);
            tach.MdiParent = this;
            tach.Show();

        }

        private void tựĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TachNguong_TuDong tach = new TachNguong_TuDong(openFileDialog.FileName);
            tach.MdiParent = this;
            tach.Show();
        }

        private void gradianToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Gradien ga=new Gradien(openFileDialog.FileName);
            ga.MdiParent = this;
            ga.Show();
        }

        private void laplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laplace L = new laplace(openFileDialog.FileName);
            L.MdiParent = this;
            L.Show();
        }

        private void nhânChậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trungVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrungVi F = new TrungVi(openFileDialog.FileName);
            F.MdiParent = this;
            F.Show();
        }

        private void trungBìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrungBinh F = new TrungBinh(openFileDialog.FileName);
            F.MdiParent = this;
            F.Show();
        }

        private void biểuĐồHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogram F = new Histogram(openFileDialog.FileName);
            F.MdiParent = this;
            F.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void prewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prewitt pr=new prewitt(openFileDialog.FileName);
            pr.MdiParent = this;
            pr.Show();
        }

        private void làmMảnhBiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LammanhBien pr = new LammanhBien(openFileDialog.FileName);
            pr.MdiParent = this;
            pr.Show();
        }
    }
}
