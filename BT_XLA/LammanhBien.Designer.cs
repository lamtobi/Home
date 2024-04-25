namespace BT_XLA
{
    partial class LammanhBien
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
            this.pic_manhbien = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_manhbien)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_manhbien
            // 
            this.pic_manhbien.Location = new System.Drawing.Point(13, 25);
            this.pic_manhbien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_manhbien.Name = "pic_manhbien";
            this.pic_manhbien.Size = new System.Drawing.Size(832, 463);
            this.pic_manhbien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_manhbien.TabIndex = 1;
            this.pic_manhbien.TabStop = false;
            // 
            // LammanhBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 574);
            this.Controls.Add(this.pic_manhbien);
            this.Name = "LammanhBien";
            this.Text = "LammanhBien";
            this.Load += new System.EventHandler(this.LammanhBien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_manhbien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_manhbien;
    }
}