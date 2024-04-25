namespace BT_XLA
{
    partial class Erosion
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
            this.pic_Ero = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ero)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Ero
            // 
            this.pic_Ero.Location = new System.Drawing.Point(13, 25);
            this.pic_Ero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_Ero.Name = "pic_Ero";
            this.pic_Ero.Size = new System.Drawing.Size(885, 487);
            this.pic_Ero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Ero.TabIndex = 2;
            this.pic_Ero.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Erosion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_Ero);
            this.Name = "Erosion";
            this.Text = "Erosion";
            this.Load += new System.EventHandler(this.Erosion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Ero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Ero;
        private System.Windows.Forms.Button button1;
    }
}