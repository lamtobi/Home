namespace BT_XLA
{
    partial class TrungVi
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
            this.pic_tc = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nm_nguong = new System.Windows.Forms.NumericUpDown();
            this.btn_run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nguong)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_tc
            // 
            this.pic_tc.Location = new System.Drawing.Point(18, 18);
            this.pic_tc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_tc.Name = "pic_tc";
            this.pic_tc.Size = new System.Drawing.Size(832, 463);
            this.pic_tc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_tc.TabIndex = 0;
            this.pic_tc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 532);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ngưỡng";
            // 
            // nm_nguong
            // 
            this.nm_nguong.Location = new System.Drawing.Point(134, 537);
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
            this.nm_nguong.TabIndex = 2;
            this.nm_nguong.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(237, 537);
            this.btn_run.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(112, 35);
            this.btn_run.TabIndex = 3;
            this.btn_run.Text = "Lọc";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // TrungVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 666);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.nm_nguong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_tc);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TrungVi";
            this.Text = "Lọc Trung Vị";
            this.Load += new System.EventHandler(this.TrungVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_tc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nguong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nm_nguong;
        private System.Windows.Forms.Button btn_run;
    }
}