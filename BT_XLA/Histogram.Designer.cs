namespace BT_XLA
{
    partial class Histogram
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
            this.pic_xam = new System.Windows.Forms.PictureBox();
            this.btn_xam = new System.Windows.Forms.Button();
            this.pic_histogram = new System.Windows.Forms.PictureBox();
            this.btn_vehistogram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_xam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_xam
            // 
            this.pic_xam.Location = new System.Drawing.Point(18, 18);
            this.pic_xam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_xam.Name = "pic_xam";
            this.pic_xam.Size = new System.Drawing.Size(783, 506);
            this.pic_xam.TabIndex = 0;
            this.pic_xam.TabStop = false;
            // 
            // btn_xam
            // 
            this.btn_xam.Location = new System.Drawing.Point(294, 565);
            this.btn_xam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xam.Name = "btn_xam";
            this.btn_xam.Size = new System.Drawing.Size(112, 35);
            this.btn_xam.TabIndex = 1;
            this.btn_xam.Text = "Chuyển Xám";
            this.btn_xam.UseVisualStyleBackColor = true;
            this.btn_xam.Click += new System.EventHandler(this.btn_xam_Click);
            // 
            // pic_histogram
            // 
            this.pic_histogram.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pic_histogram.Location = new System.Drawing.Point(886, 18);
            this.pic_histogram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_histogram.Name = "pic_histogram";
            this.pic_histogram.Size = new System.Drawing.Size(783, 506);
            this.pic_histogram.TabIndex = 2;
            this.pic_histogram.TabStop = false;
            // 
            // btn_vehistogram
            // 
            this.btn_vehistogram.Location = new System.Drawing.Point(1236, 565);
            this.btn_vehistogram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_vehistogram.Name = "btn_vehistogram";
            this.btn_vehistogram.Size = new System.Drawing.Size(112, 35);
            this.btn_vehistogram.TabIndex = 3;
            this.btn_vehistogram.Text = "Vẽ";
            this.btn_vehistogram.UseVisualStyleBackColor = true;
            this.btn_vehistogram.Click += new System.EventHandler(this.btn_vehistogram_Click);
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 618);
            this.Controls.Add(this.btn_vehistogram);
            this.Controls.Add(this.pic_histogram);
            this.Controls.Add(this.btn_xam);
            this.Controls.Add(this.pic_xam);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Histogram";
            this.Text = "Histogram";
            this.Load += new System.EventHandler(this.Histogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_xam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_histogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_xam;
        private System.Windows.Forms.Button btn_xam;
        private System.Windows.Forms.PictureBox pic_histogram;
        private System.Windows.Forms.Button btn_vehistogram;
    }
}