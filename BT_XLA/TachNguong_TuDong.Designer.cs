namespace BT_XLA
{
    partial class TachNguong_TuDong
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
            this.pic_tu = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tu)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_tu
            // 
            this.pic_tu.Location = new System.Drawing.Point(14, 79);
            this.pic_tu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_tu.Name = "pic_tu";
            this.pic_tu.Size = new System.Drawing.Size(832, 461);
            this.pic_tu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_tu.TabIndex = 5;
            this.pic_tu.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TachNguong_TuDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_tu);
            this.Name = "TachNguong_TuDong";
            this.Text = "TachNguong_TuDong";
            this.Load += new System.EventHandler(this.TachNguong_TuDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_tu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_tu;
        private System.Windows.Forms.Button button1;
    }
}