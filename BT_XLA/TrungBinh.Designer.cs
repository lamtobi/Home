namespace BT_XLA
{
    partial class TrungBinh
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
            this.pic_tb = new System.Windows.Forms.PictureBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.nm_nguong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nguong)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_tb
            // 
            this.pic_tb.Location = new System.Drawing.Point(12, 12);
            this.pic_tb.Name = "pic_tb";
            this.pic_tb.Size = new System.Drawing.Size(540, 283);
            this.pic_tb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_tb.TabIndex = 0;
            this.pic_tb.TabStop = false;
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(262, 336);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(75, 23);
            this.btn_loc.TabIndex = 1;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // nm_nguong
            // 
            this.nm_nguong.Location = new System.Drawing.Point(119, 336);
            this.nm_nguong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nm_nguong.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nm_nguong.Name = "nm_nguong";
            this.nm_nguong.Size = new System.Drawing.Size(65, 20);
            this.nm_nguong.TabIndex = 2;
            this.nm_nguong.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // TrungBinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 381);
            this.Controls.Add(this.nm_nguong);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.pic_tb);
            this.Name = "TrungBinh";
            this.Text = "TrungBinh";
            ((System.ComponentModel.ISupportInitialize)(this.pic_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nguong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_tb;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.NumericUpDown nm_nguong;
    }
}