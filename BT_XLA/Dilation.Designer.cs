namespace BT_XLA
{
    partial class Dilation
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
            this.pic_GIANNO = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_GIANNO)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_GIANNO
            // 
            this.pic_GIANNO.Location = new System.Drawing.Point(13, 27);
            this.pic_GIANNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_GIANNO.Name = "pic_GIANNO";
            this.pic_GIANNO.Size = new System.Drawing.Size(832, 450);
            this.pic_GIANNO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_GIANNO.TabIndex = 2;
            this.pic_GIANNO.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dilation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_GIANNO);
            this.Name = "Dilation";
            this.Text = "Dilation";
            this.Load += new System.EventHandler(this.Dilation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_GIANNO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_GIANNO;
        private System.Windows.Forms.Button button1;
    }
}