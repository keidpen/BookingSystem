namespace BookingSystem
{
    partial class frmAddMov
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
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.lblAddGenre = new System.Windows.Forms.Label();
            this.lblAddDuration = new System.Windows.Forms.Label();
            this.lblAddSynopsis = new System.Windows.Forms.Label();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbSynopsis = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbGenre = new System.Windows.Forms.CheckedListBox();
            this.picBoxMovie = new System.Windows.Forms.PictureBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.lblAddDirector = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(900, 492);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(180, 60);
            this.btnAddMovie.TabIndex = 22;
            this.btnAddMovie.Text = "ADD ";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTitle.Location = new System.Drawing.Point(597, 72);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(99, 20);
            this.lblAddTitle.TabIndex = 24;
            this.lblAddTitle.Text = "Movie Title:";
            // 
            // lblAddGenre
            // 
            this.lblAddGenre.AutoSize = true;
            this.lblAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGenre.Location = new System.Drawing.Point(616, 126);
            this.lblAddGenre.Name = "lblAddGenre";
            this.lblAddGenre.Size = new System.Drawing.Size(64, 20);
            this.lblAddGenre.TabIndex = 25;
            this.lblAddGenre.Text = "Genre:";
            // 
            // lblAddDuration
            // 
            this.lblAddDuration.AutoSize = true;
            this.lblAddDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDuration.Location = new System.Drawing.Point(616, 216);
            this.lblAddDuration.Name = "lblAddDuration";
            this.lblAddDuration.Size = new System.Drawing.Size(83, 20);
            this.lblAddDuration.TabIndex = 26;
            this.lblAddDuration.Text = "Duration:";
            // 
            // lblAddSynopsis
            // 
            this.lblAddSynopsis.AutoSize = true;
            this.lblAddSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSynopsis.Location = new System.Drawing.Point(610, 276);
            this.lblAddSynopsis.Name = "lblAddSynopsis";
            this.lblAddSynopsis.Size = new System.Drawing.Size(86, 20);
            this.lblAddSynopsis.TabIndex = 27;
            this.lblAddSynopsis.Text = "Synopsis:";
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPrice.Location = new System.Drawing.Point(626, 409);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(54, 20);
            this.lblAddPrice.TabIndex = 28;
            this.lblAddPrice.Text = "Price:";
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(702, 66);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(269, 26);
            this.tbTitle.TabIndex = 29;
            // 
            // tbDuration
            // 
            this.tbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuration.Location = new System.Drawing.Point(705, 225);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(269, 26);
            this.tbDuration.TabIndex = 30;
            // 
            // tbSynopsis
            // 
            this.tbSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSynopsis.Location = new System.Drawing.Point(705, 290);
            this.tbSynopsis.Multiline = true;
            this.tbSynopsis.Name = "tbSynopsis";
            this.tbSynopsis.Size = new System.Drawing.Size(269, 54);
            this.tbSynopsis.TabIndex = 31;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(705, 409);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(269, 26);
            this.tbPrice.TabIndex = 32;
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "Adventure",
            "Action",
            "Drama",
            "Documentary",
            "Comedy",
            "Fantasy",
            "Horror",
            "Romance",
            "Sci-Fi",
            "Sports",
            "Thriller"});
            this.cbGenre.Location = new System.Drawing.Point(705, 126);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(272, 79);
            this.cbGenre.TabIndex = 33;
            // 
            // picBoxMovie
            // 
            this.picBoxMovie.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picBoxMovie.Location = new System.Drawing.Point(51, 27);
            this.picBoxMovie.Name = "picBoxMovie";
            this.picBoxMovie.Size = new System.Drawing.Size(406, 447);
            this.picBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMovie.TabIndex = 34;
            this.picBoxMovie.TabStop = false;
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Location = new System.Drawing.Point(165, 492);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(144, 27);
            this.btnSelectImg.TabIndex = 37;
            this.btnSelectImg.Text = "Select Image";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // tbDirector
            // 
            this.tbDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDirector.Location = new System.Drawing.Point(722, 98);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(269, 26);
            this.tbDirector.TabIndex = 38;
            // 
            // lblAddDirector
            // 
            this.lblAddDirector.AutoSize = true;
            this.lblAddDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDirector.Location = new System.Drawing.Point(610, 101);
            this.lblAddDirector.Name = "lblAddDirector";
            this.lblAddDirector.Size = new System.Drawing.Size(78, 20);
            this.lblAddDirector.TabIndex = 39;
            this.lblAddDirector.Text = "Director:";
            // 
            // frmAddMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 568);
            this.Controls.Add(this.lblAddDirector);
            this.Controls.Add(this.tbDirector);
            this.Controls.Add(this.btnSelectImg);
            this.Controls.Add(this.picBoxMovie);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbSynopsis);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblAddPrice);
            this.Controls.Add(this.lblAddSynopsis);
            this.Controls.Add(this.lblAddDuration);
            this.Controls.Add(this.lblAddGenre);
            this.Controls.Add(this.lblAddTitle);
            this.Controls.Add(this.btnAddMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddMov";
            this.Text = "frmAddMov";
            this.Load += new System.EventHandler(this.frmAddMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Label lblAddGenre;
        private System.Windows.Forms.Label lblAddDuration;
        private System.Windows.Forms.Label lblAddSynopsis;
        private System.Windows.Forms.Label lblAddPrice;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbSynopsis;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.CheckedListBox cbGenre;
        private System.Windows.Forms.PictureBox picBoxMovie;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.Label lblAddDirector;
    }
}