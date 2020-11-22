namespace BookingSystem
{
    partial class frmMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Location = new System.Drawing.Point(12, 194);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1235, 500);
            this.pnlMenu.TabIndex = 4;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHome.Location = new System.Drawing.Point(12, 79);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(62, 23);
            this.lblHome.TabIndex = 6;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMovie.Location = new System.Drawing.Point(131, 79);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(64, 23);
            this.lblMovie.TabIndex = 7;
            this.lblMovie.Text = "Movie";
            this.lblMovie.Click += new System.EventHandler(this.lblMovie_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 706);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblMovie;
    }
}