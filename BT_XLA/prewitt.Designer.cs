namespace BT_XLA
{
    partial class prewitt
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
            this.pic_pre = new System.Windows.Forms.PictureBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.nm_nguong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nguong)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_pre
            // 
            this.pic_pre.Location = new System.Drawing.Point(23, 24);
            this.pic_pre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_pre.Name = "pic_pre";
            this.pic_pre.Size = new System.Drawing.Size(832, 461);
            this.pic_pre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_pre.TabIndex = 2;
            this.pic_pre.TabStop = false;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(321, 525);
            this.btn_run.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(112, 35);
            this.btn_run.TabIndex = 7;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // nm_nguong
            // 
            this.nm_nguong.Location = new System.Drawing.Point(191, 534);
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
            this.nm_nguong.TabIndex = 6;
            this.nm_nguong.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nm_nguong.ValueChanged += new System.EventHandler(this.nm_nguong_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 529);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngưỡng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // prewitt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 612);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.nm_nguong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_pre);
            this.Name = "prewitt";
            this.Text = "prewitt";
            this.Load += new System.EventHandler(this.prewitt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_nguong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_pre;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.NumericUpDown nm_nguong;
        private System.Windows.Forms.Label label1;
    }
}