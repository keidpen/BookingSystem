﻿namespace BookingSystem
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblBooking = new System.Windows.Forms.Label();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblCostumer = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.cbSched = new System.Windows.Forms.ComboBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblSetSched = new System.Windows.Forms.Label();
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
            this.lblAddDirector = new System.Windows.Forms.Label();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.btnUpdSelectImg = new System.Windows.Forms.Button();
            this.lblUpdDirector = new System.Windows.Forms.Label();
            this.picBoxUpdate = new System.Windows.Forms.PictureBox();
            this.cbUpdGenre = new System.Windows.Forms.CheckedListBox();
            this.tbUpdPrice = new System.Windows.Forms.TextBox();
            this.tbUpdSynopsis = new System.Windows.Forms.TextBox();
            this.tbUpdDuration = new System.Windows.Forms.TextBox();
            this.lblUpdPrice = new System.Windows.Forms.Label();
            this.lblUpdSynopsis = new System.Windows.Forms.Label();
            this.lblUpdDuration = new System.Windows.Forms.Label();
            this.lblUpdGenre = new System.Windows.Forms.Label();
            this.lblUpdTitle = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbUpdTitle = new System.Windows.Forms.ComboBox();
            this.btnSearchIdMov = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbUpdDirector = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHome.Location = new System.Drawing.Point(44, 53);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(62, 23);
            this.lblHome.TabIndex = 0;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.Location = new System.Drawing.Point(146, 53);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(64, 23);
            this.lblMovie.TabIndex = 1;
            this.lblMovie.Text = "Movie";
            this.lblMovie.Click += new System.EventHandler(this.lblMovie_Click);
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(270, 53);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(81, 23);
            this.lblBooking.TabIndex = 2;
            this.lblBooking.Text = "Booking";
            this.lblBooking.Click += new System.EventHandler(this.lblBooking_Click_1);
            // 
            // pnlBooking
            // 
            this.pnlBooking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBooking.Location = new System.Drawing.Point(48, 669);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(504, 21);
            this.pnlBooking.TabIndex = 3;
            this.pnlBooking.Visible = false;
            this.pnlBooking.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBooking_Paint);
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.Location = new System.Drawing.Point(45, 103);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(55, 23);
            this.lblSeats.TabIndex = 4;
            this.lblSeats.Text = "Seats";
            this.lblSeats.Visible = false;
            this.lblSeats.Click += new System.EventHandler(this.lblBooking_Click_1);
            // 
            // lblCostumer
            // 
            this.lblCostumer.AutoSize = true;
            this.lblCostumer.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostumer.Location = new System.Drawing.Point(138, 103);
            this.lblCostumer.Name = "lblCostumer";
            this.lblCostumer.Size = new System.Drawing.Size(93, 23);
            this.lblCostumer.TabIndex = 5;
            this.lblCostumer.Text = "Costumer";
            this.lblCostumer.Visible = false;
            this.lblCostumer.Click += new System.EventHandler(this.lblCostumer_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(49, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Screen 1",
            "Screen 2",
            "Screen 3"});
            this.comboBox1.Location = new System.Drawing.Point(342, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 500);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1111, 141);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(887, 142);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(205, 26);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.Visible = false;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(900, 135);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(205, 43);
            this.btnPayment.TabIndex = 12;
            this.btnPayment.Text = "Prooceed to Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Visible = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // cbSched
            // 
            this.cbSched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSched.FormattingEnabled = true;
            this.cbSched.Location = new System.Drawing.Point(493, 148);
            this.cbSched.Name = "cbSched";
            this.cbSched.Size = new System.Drawing.Size(184, 28);
            this.cbSched.TabIndex = 17;
            this.cbSched.Visible = false;
            this.cbSched.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(44, 103);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(45, 23);
            this.lblAdd.TabIndex = 19;
            this.lblAdd.Text = "Add";
            this.lblAdd.Visible = false;
            this.lblAdd.Click += new System.EventHandler(this.lblMovie_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.Location = new System.Drawing.Point(146, 103);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(73, 23);
            this.lblUpdate.TabIndex = 20;
            this.lblUpdate.Text = "Update";
            this.lblUpdate.Visible = false;
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(860, 595);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(180, 60);
            this.btnAddMovie.TabIndex = 21;
            this.btnAddMovie.Text = "ADD ";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Visible = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // lblSetSched
            // 
            this.lblSetSched.AutoSize = true;
            this.lblSetSched.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetSched.Location = new System.Drawing.Point(270, 103);
            this.lblSetSched.Name = "lblSetSched";
            this.lblSetSched.Size = new System.Drawing.Size(119, 23);
            this.lblSetSched.TabIndex = 22;
            this.lblSetSched.Text = "Set Schedule";
            this.lblSetSched.Visible = false;
            this.lblSetSched.Click += new System.EventHandler(this.lblSetSched_Click);
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddTitle.Location = new System.Drawing.Point(661, 173);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(99, 20);
            this.lblAddTitle.TabIndex = 23;
            this.lblAddTitle.Text = "Movie Title:";
            this.lblAddTitle.Visible = false;
            // 
            // lblAddGenre
            // 
            this.lblAddGenre.AutoSize = true;
            this.lblAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGenre.Location = new System.Drawing.Point(693, 259);
            this.lblAddGenre.Name = "lblAddGenre";
            this.lblAddGenre.Size = new System.Drawing.Size(64, 20);
            this.lblAddGenre.TabIndex = 24;
            this.lblAddGenre.Text = "Genre:";
            this.lblAddGenre.Visible = false;
            // 
            // lblAddDuration
            // 
            this.lblAddDuration.AutoSize = true;
            this.lblAddDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDuration.Location = new System.Drawing.Point(673, 358);
            this.lblAddDuration.Name = "lblAddDuration";
            this.lblAddDuration.Size = new System.Drawing.Size(83, 20);
            this.lblAddDuration.TabIndex = 25;
            this.lblAddDuration.Text = "Duration:";
            this.lblAddDuration.Visible = false;
            // 
            // lblAddSynopsis
            // 
            this.lblAddSynopsis.AutoSize = true;
            this.lblAddSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSynopsis.Location = new System.Drawing.Point(673, 407);
            this.lblAddSynopsis.Name = "lblAddSynopsis";
            this.lblAddSynopsis.Size = new System.Drawing.Size(86, 20);
            this.lblAddSynopsis.TabIndex = 26;
            this.lblAddSynopsis.Text = "Synopsis:";
            this.lblAddSynopsis.Visible = false;
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPrice.Location = new System.Drawing.Point(696, 490);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(54, 20);
            this.lblAddPrice.TabIndex = 27;
            this.lblAddPrice.Text = "Price:";
            this.lblAddPrice.Visible = false;
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(773, 172);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(269, 26);
            this.tbTitle.TabIndex = 28;
            this.tbTitle.Visible = false;
            this.tbTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbDuration
            // 
            this.tbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuration.Location = new System.Drawing.Point(774, 358);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(269, 26);
            this.tbDuration.TabIndex = 29;
            this.tbDuration.Visible = false;
            this.tbDuration.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbSynopsis
            // 
            this.tbSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSynopsis.Location = new System.Drawing.Point(774, 411);
            this.tbSynopsis.Multiline = true;
            this.tbSynopsis.Name = "tbSynopsis";
            this.tbSynopsis.Size = new System.Drawing.Size(269, 54);
            this.tbSynopsis.TabIndex = 30;
            this.tbSynopsis.Visible = false;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(772, 488);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(269, 26);
            this.tbPrice.TabIndex = 31;
            this.tbPrice.Visible = false;
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
            this.cbGenre.Location = new System.Drawing.Point(773, 260);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(272, 79);
            this.cbGenre.TabIndex = 32;
            this.cbGenre.Visible = false;
            this.cbGenre.SelectedIndexChanged += new System.EventHandler(this.cbGenre_SelectedIndexChanged);
            // 
            // picBoxMovie
            // 
            this.picBoxMovie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBoxMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxMovie.Location = new System.Drawing.Point(146, 154);
            this.picBoxMovie.Name = "picBoxMovie";
            this.picBoxMovie.Size = new System.Drawing.Size(406, 447);
            this.picBoxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMovie.TabIndex = 33;
            this.picBoxMovie.TabStop = false;
            this.picBoxMovie.Visible = false;
            this.picBoxMovie.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblAddDirector
            // 
            this.lblAddDirector.AutoSize = true;
            this.lblAddDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDirector.Location = new System.Drawing.Point(680, 220);
            this.lblAddDirector.Name = "lblAddDirector";
            this.lblAddDirector.Size = new System.Drawing.Size(78, 20);
            this.lblAddDirector.TabIndex = 34;
            this.lblAddDirector.Text = "Director:";
            this.lblAddDirector.Visible = false;
            this.lblAddDirector.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbDirector
            // 
            this.tbDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDirector.Location = new System.Drawing.Point(772, 215);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.Size = new System.Drawing.Size(269, 26);
            this.tbDirector.TabIndex = 35;
            this.tbDirector.Visible = false;
            this.tbDirector.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Location = new System.Drawing.Point(282, 615);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(144, 27);
            this.btnSelectImg.TabIndex = 36;
            this.btnSelectImg.Text = "Select Image";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            this.btnSelectImg.Visible = false;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // btnUpdSelectImg
            // 
            this.btnUpdSelectImg.Location = new System.Drawing.Point(282, 615);
            this.btnUpdSelectImg.Name = "btnUpdSelectImg";
            this.btnUpdSelectImg.Size = new System.Drawing.Size(144, 27);
            this.btnUpdSelectImg.TabIndex = 51;
            this.btnUpdSelectImg.Text = "Select New Image";
            this.btnUpdSelectImg.UseVisualStyleBackColor = true;
            this.btnUpdSelectImg.Visible = false;
            this.btnUpdSelectImg.Click += new System.EventHandler(this.btnUpdSelectImg_Click);
            // 
            // lblUpdDirector
            // 
            this.lblUpdDirector.AutoSize = true;
            this.lblUpdDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdDirector.Location = new System.Drawing.Point(680, 221);
            this.lblUpdDirector.Name = "lblUpdDirector";
            this.lblUpdDirector.Size = new System.Drawing.Size(78, 20);
            this.lblUpdDirector.TabIndex = 49;
            this.lblUpdDirector.Text = "Director:";
            this.lblUpdDirector.Visible = false;
            // 
            // picBoxUpdate
            // 
            this.picBoxUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBoxUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxUpdate.Location = new System.Drawing.Point(146, 154);
            this.picBoxUpdate.Name = "picBoxUpdate";
            this.picBoxUpdate.Size = new System.Drawing.Size(406, 447);
            this.picBoxUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUpdate.TabIndex = 48;
            this.picBoxUpdate.TabStop = false;
            this.picBoxUpdate.Visible = false;
            this.picBoxUpdate.Click += new System.EventHandler(this.picBoxUpdate_Click);
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
            this.cbUpdGenre.Location = new System.Drawing.Point(773, 261);
            this.cbUpdGenre.Name = "cbUpdGenre";
            this.cbUpdGenre.Size = new System.Drawing.Size(272, 79);
            this.cbUpdGenre.TabIndex = 47;
            this.cbUpdGenre.Visible = false;
            // 
            // tbUpdPrice
            // 
            this.tbUpdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdPrice.Location = new System.Drawing.Point(772, 491);
            this.tbUpdPrice.Name = "tbUpdPrice";
            this.tbUpdPrice.Size = new System.Drawing.Size(269, 26);
            this.tbUpdPrice.TabIndex = 46;
            this.tbUpdPrice.Visible = false;
            // 
            // tbUpdSynopsis
            // 
            this.tbUpdSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdSynopsis.Location = new System.Drawing.Point(774, 414);
            this.tbUpdSynopsis.Multiline = true;
            this.tbUpdSynopsis.Name = "tbUpdSynopsis";
            this.tbUpdSynopsis.Size = new System.Drawing.Size(269, 54);
            this.tbUpdSynopsis.TabIndex = 45;
            this.tbUpdSynopsis.Visible = false;
            // 
            // tbUpdDuration
            // 
            this.tbUpdDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdDuration.Location = new System.Drawing.Point(774, 361);
            this.tbUpdDuration.Name = "tbUpdDuration";
            this.tbUpdDuration.Size = new System.Drawing.Size(269, 26);
            this.tbUpdDuration.TabIndex = 44;
            this.tbUpdDuration.Visible = false;
            // 
            // lblUpdPrice
            // 
            this.lblUpdPrice.AutoSize = true;
            this.lblUpdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdPrice.Location = new System.Drawing.Point(696, 491);
            this.lblUpdPrice.Name = "lblUpdPrice";
            this.lblUpdPrice.Size = new System.Drawing.Size(54, 20);
            this.lblUpdPrice.TabIndex = 42;
            this.lblUpdPrice.Text = "Price:";
            this.lblUpdPrice.Visible = false;
            // 
            // lblUpdSynopsis
            // 
            this.lblUpdSynopsis.AutoSize = true;
            this.lblUpdSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdSynopsis.Location = new System.Drawing.Point(673, 408);
            this.lblUpdSynopsis.Name = "lblUpdSynopsis";
            this.lblUpdSynopsis.Size = new System.Drawing.Size(86, 20);
            this.lblUpdSynopsis.TabIndex = 41;
            this.lblUpdSynopsis.Text = "Synopsis:";
            this.lblUpdSynopsis.Visible = false;
            // 
            // lblUpdDuration
            // 
            this.lblUpdDuration.AutoSize = true;
            this.lblUpdDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdDuration.Location = new System.Drawing.Point(673, 359);
            this.lblUpdDuration.Name = "lblUpdDuration";
            this.lblUpdDuration.Size = new System.Drawing.Size(83, 20);
            this.lblUpdDuration.TabIndex = 40;
            this.lblUpdDuration.Text = "Duration:";
            this.lblUpdDuration.Visible = false;
            // 
            // lblUpdGenre
            // 
            this.lblUpdGenre.AutoSize = true;
            this.lblUpdGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdGenre.Location = new System.Drawing.Point(693, 260);
            this.lblUpdGenre.Name = "lblUpdGenre";
            this.lblUpdGenre.Size = new System.Drawing.Size(64, 20);
            this.lblUpdGenre.TabIndex = 39;
            this.lblUpdGenre.Text = "Genre:";
            this.lblUpdGenre.Visible = false;
            // 
            // lblUpdTitle
            // 
            this.lblUpdTitle.AutoSize = true;
            this.lblUpdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdTitle.Location = new System.Drawing.Point(661, 174);
            this.lblUpdTitle.Name = "lblUpdTitle";
            this.lblUpdTitle.Size = new System.Drawing.Size(99, 20);
            this.lblUpdTitle.TabIndex = 38;
            this.lblUpdTitle.Text = "Movie Title:";
            this.lblUpdTitle.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(860, 596);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 60);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbUpdTitle
            // 
            this.cbUpdTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUpdTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUpdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUpdTitle.FormattingEnabled = true;
            this.cbUpdTitle.Location = new System.Drawing.Point(774, 171);
            this.cbUpdTitle.Name = "cbUpdTitle";
            this.cbUpdTitle.Size = new System.Drawing.Size(266, 28);
            this.cbUpdTitle.TabIndex = 52;
            this.cbUpdTitle.Visible = false;
            // 
            // btnSearchIdMov
            // 
            this.btnSearchIdMov.Location = new System.Drawing.Point(1059, 172);
            this.btnSearchIdMov.Name = "btnSearchIdMov";
            this.btnSearchIdMov.Size = new System.Drawing.Size(88, 28);
            this.btnSearchIdMov.TabIndex = 53;
            this.btnSearchIdMov.Text = "Select";
            this.btnSearchIdMov.UseVisualStyleBackColor = true;
            this.btnSearchIdMov.Visible = false;
            this.btnSearchIdMov.Click += new System.EventHandler(this.btnSearchIdMov_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1198, 558);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // tbUpdDirector
            // 
            this.tbUpdDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdDirector.Location = new System.Drawing.Point(773, 218);
            this.tbUpdDirector.Name = "tbUpdDirector";
            this.tbUpdDirector.Size = new System.Drawing.Size(269, 26);
            this.tbUpdDirector.TabIndex = 54;
            this.tbUpdDirector.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 705);
            this.Controls.Add(this.tbUpdDirector);
            this.Controls.Add(this.btnSearchIdMov);
            this.Controls.Add(this.cbUpdTitle);
            this.Controls.Add(this.btnUpdSelectImg);
            this.Controls.Add(this.lblUpdDirector);
            this.Controls.Add(this.picBoxUpdate);
            this.Controls.Add(this.cbUpdGenre);
            this.Controls.Add(this.tbUpdPrice);
            this.Controls.Add(this.tbUpdSynopsis);
            this.Controls.Add(this.tbUpdDuration);
            this.Controls.Add(this.lblUpdPrice);
            this.Controls.Add(this.lblUpdSynopsis);
            this.Controls.Add(this.lblUpdDuration);
            this.Controls.Add(this.lblUpdGenre);
            this.Controls.Add(this.lblUpdTitle);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectImg);
            this.Controls.Add(this.tbDirector);
            this.Controls.Add(this.lblAddDirector);
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
            this.Controls.Add(this.lblSetSched);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.cbSched);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblCostumer);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.pnlBooking);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblCostumer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.ComboBox cbSched;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label lblSetSched;
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
        private System.Windows.Forms.Label lblAddDirector;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.Button btnUpdSelectImg;
        private System.Windows.Forms.Label lblUpdDirector;
        private System.Windows.Forms.PictureBox picBoxUpdate;
        private System.Windows.Forms.CheckedListBox cbUpdGenre;
        private System.Windows.Forms.TextBox tbUpdPrice;
        private System.Windows.Forms.TextBox tbUpdSynopsis;
        private System.Windows.Forms.TextBox tbUpdDuration;
        private System.Windows.Forms.Label lblUpdPrice;
        private System.Windows.Forms.Label lblUpdSynopsis;
        private System.Windows.Forms.Label lblUpdDuration;
        private System.Windows.Forms.Label lblUpdGenre;
        private System.Windows.Forms.Label lblUpdTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbUpdTitle;
        private System.Windows.Forms.Button btnSearchIdMov;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbUpdDirector;
    }
}