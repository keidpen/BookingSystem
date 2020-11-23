namespace BookingSystem
{
    partial class frmSearchMov
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchMov));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbCategoryMovieInfo = new System.Windows.Forms.ComboBox();
            this.tbSearchMovieInfo = new System.Windows.Forms.TextBox();
            this.btnSearchMovieInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // cbCategoryMovieInfo
            // 
            this.cbCategoryMovieInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbCategoryMovieInfo, "cbCategoryMovieInfo");
            this.cbCategoryMovieInfo.FormattingEnabled = true;
            this.cbCategoryMovieInfo.Items.AddRange(new object[] {
            resources.GetString("cbCategoryMovieInfo.Items"),
            resources.GetString("cbCategoryMovieInfo.Items1"),
            resources.GetString("cbCategoryMovieInfo.Items2"),
            resources.GetString("cbCategoryMovieInfo.Items3")});
            this.cbCategoryMovieInfo.Name = "cbCategoryMovieInfo";
            this.cbCategoryMovieInfo.SelectedIndexChanged += new System.EventHandler(this.cbCategoryMovieInfo_SelectedIndexChanged);
            // 
            // tbSearchMovieInfo
            // 
            this.tbSearchMovieInfo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSearchMovieInfo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            resources.ApplyResources(this.tbSearchMovieInfo, "tbSearchMovieInfo");
            this.tbSearchMovieInfo.Name = "tbSearchMovieInfo";
            // 
            // btnSearchMovieInfo
            // 
            resources.ApplyResources(this.btnSearchMovieInfo, "btnSearchMovieInfo");
            this.btnSearchMovieInfo.Name = "btnSearchMovieInfo";
            this.btnSearchMovieInfo.UseVisualStyleBackColor = true;
            this.btnSearchMovieInfo.Click += new System.EventHandler(this.btnSearchMovieInfo_Click_1);
            // 
            // frmSearchMov
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchMovieInfo);
            this.Controls.Add(this.tbSearchMovieInfo);
            this.Controls.Add(this.cbCategoryMovieInfo);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSearchMov";
            this.Load += new System.EventHandler(this.SearchMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbCategoryMovieInfo;
        private System.Windows.Forms.TextBox tbSearchMovieInfo;
        private System.Windows.Forms.Button btnSearchMovieInfo;
    }
}