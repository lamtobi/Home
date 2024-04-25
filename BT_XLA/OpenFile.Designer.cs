namespace BT_XLA
{
    partial class OpenFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pic_goc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_goc
            // 
            this.pic_goc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_goc.Location = new System.Drawing.Point(0, 0);
            this.pic_goc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_goc.Name = "pic_goc";
            this.pic_goc.Size = new System.Drawing.Size(690, 548);
            this.pic_goc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_goc.TabIndex = 0;
            this.pic_goc.TabStop = false;
            // 
            // OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 548);
            this.Controls.Add(this.pic_goc);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OpenFile";
            this.Text = "Ảnh Gốc";
            this.Load += new System.EventHandler(this.OpenFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_goc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_goc;
    }
}

