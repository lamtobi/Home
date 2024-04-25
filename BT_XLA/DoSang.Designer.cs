namespace BT_XLA
{
    partial class DoSang
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
            this.trb_C = new System.Windows.Forms.TrackBar();
            this.lb_C = new System.Windows.Forms.Label();
            this.pb_dosang = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trb_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dosang)).BeginInit();
            this.SuspendLayout();
            // 
            // trb_C
            // 
            this.trb_C.Location = new System.Drawing.Point(240, 535);
            this.trb_C.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trb_C.Maximum = 255;
            this.trb_C.Minimum = -255;
            this.trb_C.Name = "trb_C";
            this.trb_C.Size = new System.Drawing.Size(555, 69);
            this.trb_C.TabIndex = 11;
            this.trb_C.Scroll += new System.EventHandler(this.trb_C_Scroll);
            this.trb_C.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // lb_C
            // 
            this.lb_C.BackColor = System.Drawing.Color.Black;
            this.lb_C.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_C.ForeColor = System.Drawing.Color.Lime;
            this.lb_C.Location = new System.Drawing.Point(126, 535);
            this.lb_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_C.Name = "lb_C";
            this.lb_C.Size = new System.Drawing.Size(105, 43);
            this.lb_C.TabIndex = 12;
            this.lb_C.Text = "0";
            this.lb_C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_C.Click += new System.EventHandler(this.lb_C_Click);
            // 
            // pb_dosang
            // 
            this.pb_dosang.Location = new System.Drawing.Point(18, 18);
            this.pb_dosang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb_dosang.Name = "pb_dosang";
            this.pb_dosang.Size = new System.Drawing.Size(832, 489);
            this.pb_dosang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_dosang.TabIndex = 13;
            this.pb_dosang.TabStop = false;
            // 
            // DoSang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 657);
            this.Controls.Add(this.pb_dosang);
            this.Controls.Add(this.lb_C);
            this.Controls.Add(this.trb_C);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DoSang";
            this.Text = "Tăng Giảm Độ Sáng";
            this.Load += new System.EventHandler(this.DoSang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trb_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dosang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trb_C;
        private System.Windows.Forms.Label lb_C;
        private System.Windows.Forms.PictureBox pb_dosang;
    }
}