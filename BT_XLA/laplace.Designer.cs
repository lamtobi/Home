namespace BT_XLA
{
    partial class laplace
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
            this.pic_lap = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nm_nguong = new System.Windows.Forms.NumericUpDown();
            this.btn_run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nguong)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_lap
            // 
            this.pic_lap.Location = new System.Drawing.Point(13, 14);
            this.pic_lap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_lap.Name = "pic_lap";
            this.pic_lap.Size = new System.Drawing.Size(832, 461);
            this.pic_lap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_lap.TabIndex = 1;
            this.pic_lap.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 505);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngưỡng";
            // 
            // nm_nguong
            // 
            this.nm_nguong.Location = new System.Drawing.Point(147, 510);
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
            this.nm_nguong.TabIndex = 3;
            this.nm_nguong.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(277, 501);
            this.btn_run.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(112, 35);
            this.btn_run.TabIndex = 4;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // laplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 569);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.nm_nguong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_lap);
            this.Name = "laplace";
            this.Text = "laplace";
            this.Load += new System.EventHandler(this.laplace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_lap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nguong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_lap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nm_nguong;
        private System.Windows.Forms.Button btn_run;
    }
}