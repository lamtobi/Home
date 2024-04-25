namespace BT_XLA
{
    partial class Opening
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
            this.pcb_open = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_open)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_open
            // 
            this.pcb_open.Location = new System.Drawing.Point(19, 26);
            this.pcb_open.Name = "pcb_open";
            this.pcb_open.Size = new System.Drawing.Size(793, 389);
            this.pcb_open.TabIndex = 0;
            this.pcb_open.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Opening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcb_open);
            this.Name = "Opening";
            this.Text = "Opening";
            this.Load += new System.EventHandler(this.Opening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_open)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_open;
        private System.Windows.Forms.Button button1;
    }
}