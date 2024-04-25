namespace BT_XLA
{
    partial class TachNguong_ThuCong
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
            this.pic_thu = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nm_nguong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pic_thu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nguong)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_thu
            // 
            this.pic_thu.Location = new System.Drawing.Point(13, 29);
            this.pic_thu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_thu.Name = "pic_thu";
            this.pic_thu.Size = new System.Drawing.Size(832, 461);
            this.pic_thu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_thu.TabIndex = 4;
            this.pic_thu.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 530);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngưỡng";
            // 
            // nm_nguong
            // 
            this.nm_nguong.Location = new System.Drawing.Point(152, 536);
            this.nm_nguong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.nm_nguong.Size = new System.Drawing.Size(72, 26);
            this.nm_nguong.TabIndex = 7;
            this.nm_nguong.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // TachNguong_ThuCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 597);
            this.Controls.Add(this.nm_nguong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_thu);
            this.Name = "TachNguong_ThuCong";
            this.Text = "TachNguong_ThuCong";
            this.Load += new System.EventHandler(this.TachNguong_ThuCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_thu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nguong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_thu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nm_nguong;
    }
}