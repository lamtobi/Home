namespace BT_XLA
{
    partial class Gradien
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
            this.pic_gra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gra)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_gra
            // 
            this.pic_gra.Location = new System.Drawing.Point(22, 72);
            this.pic_gra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_gra.Name = "pic_gra";
            this.pic_gra.Size = new System.Drawing.Size(832, 461);
            this.pic_gra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_gra.TabIndex = 3;
            this.pic_gra.TabStop = false;
            // 
            // Gradien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 604);
            this.Controls.Add(this.pic_gra);
            this.Name = "Gradien";
            this.Text = "Gradien";
            this.Load += new System.EventHandler(this.Gradien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_gra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_gra;
    }
}