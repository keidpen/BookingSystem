namespace BookingSystem
{
    partial class Form4
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
            this.btnPullout = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblScreen = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.picBoxMovie = new System.Windows.Forms.PictureBox();
            this.cbSaturday = new System.Windows.Forms.CheckBox();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.cbTuesday = new System.Windows.Forms.CheckBox();
            this.cbMonday = new System.Windows.Forms.CheckBox();
            this.cbSunday = new System.Windows.Forms.CheckBox();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPullout
            // 
            this.btnPullout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPullout.Location = new System.Drawing.Point(227, 452);
            this.btnPullout.Name = "btnPullout";
            this.btnPullout.Size = new System.Drawing.Size(154, 58);
            this.btnPullout.TabIndex = 0;
            this.btnPullout.Text = "PULL OUT";
            this.btnPullout.UseVisualStyleBackColor = true;
            this.btnPullout.Click += new System.EventHandler(this.btnPullout_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(412, 452);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 58);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(605, 452);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(154, 58);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "SET";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(449, 58);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(91, 20);
            this.lblMovieTitle.TabIndex = 3;
            this.lblMovieTitle.Text = "Movie Title: ";
            // 
            // lblScreen
            // 
            this.lblScreen.AutoSize = true;
            this.lblScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreen.Location = new System.Drawing.Point(449, 112);
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Size = new System.Drawing.Size(60, 20);
            this.lblScreen.TabIndex = 4;
            this.lblScreen.Text = "Screen";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(449, 172);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // picBoxMovie
            // 
            this.picBoxMovie.Location = new System.Drawing.Point(28, 27);
            this.picBoxMovie.Name = "picBoxMovie";
            this.picBoxMovie.Size = new System.Drawing.Size(274, 309);
            this.picBoxMovie.TabIndex = 6;
            this.picBoxMovie.TabStop = false;
            // 
            // cbSaturday
            // 
            this.cbSaturday.AutoSize = true;
            this.cbSaturday.Location = new System.Drawing.Point(396, 388);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(68, 17);
            this.cbSaturday.TabIndex = 7;
            this.cbSaturday.Text = "Saturday";
            this.cbSaturday.UseVisualStyleBackColor = true;
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.Location = new System.Drawing.Point(396, 365);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(54, 17);
            this.cbFriday.TabIndex = 8;
            this.cbFriday.Text = "Friday";
            this.cbFriday.UseVisualStyleBackColor = true;
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.Location = new System.Drawing.Point(396, 342);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(70, 17);
            this.cbThursday.TabIndex = 10;
            this.cbThursday.Text = "Thursday";
            this.cbThursday.UseVisualStyleBackColor = true;
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.Location = new System.Drawing.Point(396, 319);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(83, 17);
            this.cbWednesday.TabIndex = 9;
            this.cbWednesday.Text = "Wednesday";
            this.cbWednesday.UseVisualStyleBackColor = true;
            // 
            // cbTuesday
            // 
            this.cbTuesday.AutoSize = true;
            this.cbTuesday.Location = new System.Drawing.Point(396, 293);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(67, 17);
            this.cbTuesday.TabIndex = 11;
            this.cbTuesday.Text = "Tuesday";
            this.cbTuesday.UseVisualStyleBackColor = true;
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.Location = new System.Drawing.Point(396, 270);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(64, 17);
            this.cbMonday.TabIndex = 12;
            this.cbMonday.Text = "Monday";
            this.cbMonday.UseVisualStyleBackColor = true;
            // 
            // cbSunday
            // 
            this.cbSunday.AutoSize = true;
            this.cbSunday.Location = new System.Drawing.Point(396, 247);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(62, 17);
            this.cbSunday.TabIndex = 13;
            this.cbSunday.Text = "Sunday";
            this.cbSunday.UseVisualStyleBackColor = true;
            // 
            // cbTitle
            // 
            this.cbTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(547, 58);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(212, 28);
            this.cbTitle.TabIndex = 14;
            this.cbTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTitle_KeyDown);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 542);
            this.Controls.Add(this.cbTitle);
            this.Controls.Add(this.cbSunday);
            this.Controls.Add(this.cbMonday);
            this.Controls.Add(this.cbTuesday);
            this.Controls.Add(this.cbThursday);
            this.Controls.Add(this.cbWednesday);
            this.Controls.Add(this.cbFriday);
            this.Controls.Add(this.cbSaturday);
            this.Controls.Add(this.picBoxMovie);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScreen);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPullout);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPullout;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox picBoxMovie;
        private System.Windows.Forms.CheckBox cbSaturday;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.CheckBox cbTuesday;
        private System.Windows.Forms.CheckBox cbMonday;
        private System.Windows.Forms.CheckBox cbSunday;
        private System.Windows.Forms.ComboBox cbTitle;
    }
}