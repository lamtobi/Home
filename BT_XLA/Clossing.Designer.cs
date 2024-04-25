namespace BT_XLA
{
    partial class Clossing
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
            this.pcb_closs = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_closs)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_closs
            // 
            this.pcb_closs.Location = new System.Drawing.Point(12, 28);
            this.pcb_closs.Name = "pcb_closs";
            this.pcb_closs.Size = new System.Drawing.Size(793, 389);
            this.pcb_closs.TabIndex = 1;
            this.pcb_closs.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clossing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 514);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pcb_closs);
            this.Name = "Clossing";
            this.Text = "Clossing";
            this.Load += new System.EventHandler(this.Clossing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_closs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_closs;
        private System.Windows.Forms.Button button1;
    }
}