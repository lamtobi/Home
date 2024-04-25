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
            ((System.ComponentModel.ISupportInitialize)(this.pic_pre)).BeginInit();
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
            // prewitt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 380);
            this.Controls.Add(this.pic_pre);
            this.Name = "prewitt";
            this.Text = "prewitt";
            this.Load += new System.EventHandler(this.prewitt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_pre;
    }
}