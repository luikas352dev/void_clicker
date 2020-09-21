namespace void_client
{
    partial class frm_clicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_clicker));
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.lb_logo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_close
            // 
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(614, 31);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(10, 10);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 5;
            this.pic_close.TabStop = false;
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold);
            this.lb_logo.ForeColor = System.Drawing.Color.White;
            this.lb_logo.Location = new System.Drawing.Point(37, 24);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(47, 23);
            this.lb_logo.TabIndex = 4;
            this.lb_logo.Text = "void";
            // 
            // frm_clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(660, 386);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.lb_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_clicker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Label lb_logo;
    }
}