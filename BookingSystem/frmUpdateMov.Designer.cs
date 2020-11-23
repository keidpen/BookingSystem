namespace BookingSystem
{
    partial class frmUpdateMov
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
            this.cbUpdGenre = new System.Windows.Forms.CheckedListBox();
            this.picBoxUpdate = new System.Windows.Forms.PictureBox();
            this.btnUpdSelectImg = new System.Windows.Forms.Button();
            this.tbUpdPrice = new System.Windows.Forms.TextBox();
            this.lblUpdPrice = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbUpdDuration = new System.Windows.Forms.TextBox();
            this.tbUpdSynopsis = new System.Windows.Forms.TextBox();
            this.tbUpdDirector = new System.Windows.Forms.TextBox();
            this.cbUpdTitle = new System.Windows.Forms.ComboBox();
            this.lblUpdDuration = new System.Windows.Forms.Label();
            this.lblUpdGenre = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearchIdMov = new System.Windows.Forms.Button();
            this.lblUpdSynopsis = new System.Windows.Forms.Label();
            this.lblUpdTitle = new System.Windows.Forms.Label();
            this.lblUpdDirector = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // cbUpdGenre
            // 
            this.cbUpdGenre.FormattingEnabled = true;
            this.cbUpdGenre.Items.AddRange(new object[] {
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
            this.cbUpdGenre.Location = new System.Drawing.Point(641, 122);
            this.cbUpdGenre.Name = "cbUpdGenre";
            this.cbUpdGenre.Size = new System.Drawing.Size(272, 79);
            this.cbUpdGenre.TabIndex = 48;
            // 
            // picBoxUpdate
            // 
            this.picBoxUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picBoxUpdate.Location = new System.Drawing.Point(105, 12);
            this.picBoxUpdate.Name = "picBoxUpdate";
            this.picBoxUpdate.Size = new System.Drawing.Size(406, 447);
            this.picBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUpdate.TabIndex = 49;
            this.picBoxUpdate.TabStop = false;
            // 
            // btnUpdSelectImg
            // 
            this.btnUpdSelectImg.Location = new System.Drawing.Point(164, 474);
            this.btnUpdSelectImg.Name = "btnUpdSelectImg";
            this.btnUpdSelectImg.Size = new System.Drawing.Size(144, 27);
            this.btnUpdSelectImg.TabIndex = 52;
            this.btnUpdSelectImg.Text = "Select New Image";
            this.btnUpdSelectImg.UseVisualStyleBackColor = true;
            this.btnUpdSelectImg.Click += new System.EventHandler(this.btnUpdSelectImg_Click);
            // 
            // tbUpdPrice
            // 
            this.tbUpdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdPrice.Location = new System.Drawing.Point(644, 374);
            this.tbUpdPrice.Name = "tbUpdPrice";
            this.tbUpdPrice.Size = new System.Drawing.Size(269, 26);
            this.tbUpdPrice.TabIndex = 53;
            // 
            // lblUpdPrice
            // 
            this.lblUpdPrice.AutoSize = true;
            this.lblUpdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdPrice.Location = new System.Drawing.Point(546, 374);
            this.lblUpdPrice.Name = "lblUpdPrice";
            this.lblUpdPrice.Size = new System.Drawing.Size(54, 20);
            this.lblUpdPrice.TabIndex = 54;
            this.lblUpdPrice.Text = "Price:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(956, 474);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 60);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbUpdDuration
            // 
            this.tbUpdDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdDuration.Location = new System.Drawing.Point(644, 236);
            this.tbUpdDuration.Name = "tbUpdDuration";
            this.tbUpdDuration.Size = new System.Drawing.Size(269, 26);
            this.tbUpdDuration.TabIndex = 56;
            // 
            // tbUpdSynopsis
            // 
            this.tbUpdSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdSynopsis.Location = new System.Drawing.Point(644, 288);
            this.tbUpdSynopsis.Multiline = true;
            this.tbUpdSynopsis.Name = "tbUpdSynopsis";
            this.tbUpdSynopsis.Size = new System.Drawing.Size(269, 54);
            this.tbUpdSynopsis.TabIndex = 57;
            // 
            // tbUpdDirector
            // 
            this.tbUpdDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdDirector.Location = new System.Drawing.Point(644, 78);
            this.tbUpdDirector.Name = "tbUpdDirector";
            this.tbUpdDirector.Size = new System.Drawing.Size(269, 26);
            this.tbUpdDirector.TabIndex = 58;
            this.tbUpdDirector.TextChanged += new System.EventHandler(this.tbUpdDirector_TextChanged);
            // 
            // cbUpdTitle
            // 
            this.cbUpdTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUpdTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUpdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdTitle.FormattingEnabled = true;
            this.cbUpdTitle.Location = new System.Drawing.Point(644, 31);
            this.cbUpdTitle.Name = "cbUpdTitle";
            this.cbUpdTitle.Size = new System.Drawing.Size(266, 28);
            this.cbUpdTitle.TabIndex = 59;
            // 
            // lblUpdDuration
            // 
            this.lblUpdDuration.AutoSize = true;
            this.lblUpdDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdDuration.Location = new System.Drawing.Point(537, 236);
            this.lblUpdDuration.Name = "lblUpdDuration";
            this.lblUpdDuration.Size = new System.Drawing.Size(83, 20);
            this.lblUpdDuration.TabIndex = 60;
            this.lblUpdDuration.Text = "Duration:";
            // 
            // lblUpdGenre
            // 
            this.lblUpdGenre.AutoSize = true;
            this.lblUpdGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdGenre.Location = new System.Drawing.Point(556, 122);
            this.lblUpdGenre.Name = "lblUpdGenre";
            this.lblUpdGenre.Size = new System.Drawing.Size(64, 20);
            this.lblUpdGenre.TabIndex = 61;
            this.lblUpdGenre.Text = "Genre:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(670, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 60);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearchIdMov
            // 
            this.btnSearchIdMov.Location = new System.Drawing.Point(922, 31);
            this.btnSearchIdMov.Name = "btnSearchIdMov";
            this.btnSearchIdMov.Size = new System.Drawing.Size(88, 28);
            this.btnSearchIdMov.TabIndex = 63;
            this.btnSearchIdMov.Text = "Select";
            this.btnSearchIdMov.UseVisualStyleBackColor = true;
            this.btnSearchIdMov.Click += new System.EventHandler(this.btnSearchIdMov_Click);
            // 
            // lblUpdSynopsis
            // 
            this.lblUpdSynopsis.AutoSize = true;
            this.lblUpdSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdSynopsis.Location = new System.Drawing.Point(546, 288);
            this.lblUpdSynopsis.Name = "lblUpdSynopsis";
            this.lblUpdSynopsis.Size = new System.Drawing.Size(86, 20);
            this.lblUpdSynopsis.TabIndex = 64;
            this.lblUpdSynopsis.Text = "Synopsis:";
            // 
            // lblUpdTitle
            // 
            this.lblUpdTitle.AutoSize = true;
            this.lblUpdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdTitle.Location = new System.Drawing.Point(533, 31);
            this.lblUpdTitle.Name = "lblUpdTitle";
            this.lblUpdTitle.Size = new System.Drawing.Size(99, 20);
            this.lblUpdTitle.TabIndex = 65;
            this.lblUpdTitle.Text = "Movie Title:";
            // 
            // lblUpdDirector
            // 
            this.lblUpdDirector.AutoSize = true;
            this.lblUpdDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdDirector.Location = new System.Drawing.Point(546, 78);
            this.lblUpdDirector.Name = "lblUpdDirector";
            this.lblUpdDirector.Size = new System.Drawing.Size(78, 20);
            this.lblUpdDirector.TabIndex = 66;
            this.lblUpdDirector.Text = "Director:";
            // 
            // frmUpdateMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 553);
            this.Controls.Add(this.lblUpdDirector);
            this.Controls.Add(this.lblUpdTitle);
            this.Controls.Add(this.lblUpdSynopsis);
            this.Controls.Add(this.btnSearchIdMov);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblUpdGenre);
            this.Controls.Add(this.lblUpdDuration);
            this.Controls.Add(this.cbUpdTitle);
            this.Controls.Add(this.tbUpdDirector);
            this.Controls.Add(this.tbUpdSynopsis);
            this.Controls.Add(this.tbUpdDuration);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUpdPrice);
            this.Controls.Add(this.tbUpdPrice);
            this.Controls.Add(this.btnUpdSelectImg);
            this.Controls.Add(this.picBoxUpdate);
            this.Controls.Add(this.cbUpdGenre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateMov";
            this.Text = "frmUpdateMov";
            this.Load += new System.EventHandler(this.frmUpdateMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbUpdGenre;
        private System.Windows.Forms.PictureBox picBoxUpdate;
        private System.Windows.Forms.Button btnUpdSelectImg;
        private System.Windows.Forms.TextBox tbUpdPrice;
        private System.Windows.Forms.Label lblUpdPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbUpdDuration;
        private System.Windows.Forms.TextBox tbUpdSynopsis;
        private System.Windows.Forms.TextBox tbUpdDirector;
        private System.Windows.Forms.ComboBox cbUpdTitle;
        private System.Windows.Forms.Label lblUpdDuration;
        private System.Windows.Forms.Label lblUpdGenre;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearchIdMov;
        private System.Windows.Forms.Label lblUpdSynopsis;
        private System.Windows.Forms.Label lblUpdTitle;
        private System.Windows.Forms.Label lblUpdDirector;
    }
}