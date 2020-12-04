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
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblSocialDistancing = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblAddMov = new System.Windows.Forms.Label();
            this.lblUpdateMov = new System.Windows.Forms.Label();
            this.lblSearchMovie = new System.Windows.Forms.Label();
            this.lblContactTracing = new System.Windows.Forms.Label();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblTimeClock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMenu.Location = new System.Drawing.Point(12, 138);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1235, 591);
            this.pnlMenu.TabIndex = 4;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHome.Location = new System.Drawing.Point(44, 53);
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
            this.lblMovie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMovie.Location = new System.Drawing.Point(150, 53);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(64, 23);
            this.lblMovie.TabIndex = 7;
            this.lblMovie.Text = "Movie";
            this.lblMovie.Click += new System.EventHandler(this.lblMovie_Click);
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.Location = new System.Drawing.Point(264, 53);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(81, 23);
            this.lblBooking.TabIndex = 8;
            this.lblBooking.Text = "Booking";
            this.lblBooking.Click += new System.EventHandler(this.lblBooking_Click);
            // 
            // lblSocialDistancing
            // 
            this.lblSocialDistancing.AutoSize = true;
            this.lblSocialDistancing.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocialDistancing.Location = new System.Drawing.Point(501, 53);
            this.lblSocialDistancing.Name = "lblSocialDistancing";
            this.lblSocialDistancing.Size = new System.Drawing.Size(150, 23);
            this.lblSocialDistancing.TabIndex = 10;
            this.lblSocialDistancing.Text = "SocialDistancing";
            this.lblSocialDistancing.Visible = false;
            this.lblSocialDistancing.Click += new System.EventHandler(this.lblSocialDistancing_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(335, 20);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(93, 23);
            this.lblCustomer.TabIndex = 11;
            this.lblCustomer.Text = "Costumer";
            this.lblCustomer.Visible = false;
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.Location = new System.Drawing.Point(481, 103);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(87, 23);
            this.lblSchedule.TabIndex = 12;
            this.lblSchedule.Text = "Schedule";
            this.lblSchedule.Visible = false;
            this.lblSchedule.Click += new System.EventHandler(this.lblSchedule_Click);
            // 
            // lblAddMov
            // 
            this.lblAddMov.AutoSize = true;
            this.lblAddMov.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMov.Location = new System.Drawing.Point(44, 103);
            this.lblAddMov.Name = "lblAddMov";
            this.lblAddMov.Size = new System.Drawing.Size(104, 23);
            this.lblAddMov.TabIndex = 13;
            this.lblAddMov.Text = "Add Movie";
            this.lblAddMov.Visible = false;
            this.lblAddMov.Click += new System.EventHandler(this.lblAddMov_Click);
            // 
            // lblUpdateMov
            // 
            this.lblUpdateMov.AutoSize = true;
            this.lblUpdateMov.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMov.Location = new System.Drawing.Point(177, 103);
            this.lblUpdateMov.Name = "lblUpdateMov";
            this.lblUpdateMov.Size = new System.Drawing.Size(132, 23);
            this.lblUpdateMov.TabIndex = 14;
            this.lblUpdateMov.Text = "Update Movie";
            this.lblUpdateMov.Visible = false;
            this.lblUpdateMov.Click += new System.EventHandler(this.lblUpdateMov_Click);
            // 
            // lblSearchMovie
            // 
            this.lblSearchMovie.AutoSize = true;
            this.lblSearchMovie.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMovie.Location = new System.Drawing.Point(330, 103);
            this.lblSearchMovie.Name = "lblSearchMovie";
            this.lblSearchMovie.Size = new System.Drawing.Size(126, 23);
            this.lblSearchMovie.TabIndex = 15;
            this.lblSearchMovie.Text = "Search Movie";
            this.lblSearchMovie.Visible = false;
            this.lblSearchMovie.Click += new System.EventHandler(this.lblSearchMovie_Click);
            // 
            // lblContactTracing
            // 
            this.lblContactTracing.AutoSize = true;
            this.lblContactTracing.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactTracing.Location = new System.Drawing.Point(752, 103);
            this.lblContactTracing.Name = "lblContactTracing";
            this.lblContactTracing.Size = new System.Drawing.Size(143, 23);
            this.lblContactTracing.TabIndex = 16;
            this.lblContactTracing.Text = "Contact Tracing";
            this.lblContactTracing.Visible = false;
            this.lblContactTracing.Click += new System.EventHandler(this.lblContactTracing_Click);
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatures.Location = new System.Drawing.Point(395, 53);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(83, 23);
            this.lblFeatures.TabIndex = 17;
            this.lblFeatures.Text = "Features";
            this.lblFeatures.Click += new System.EventHandler(this.lblFeatures_Click);
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.Location = new System.Drawing.Point(274, 20);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(55, 23);
            this.lblSeats.TabIndex = 18;
            this.lblSeats.Text = "Seats";
            this.lblSeats.Visible = false;
            this.lblSeats.Click += new System.EventHandler(this.lblBooking_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1040, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 19;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblTimeClock
            // 
            this.lblTimeClock.AutoSize = true;
            this.lblTimeClock.Location = new System.Drawing.Point(673, 12);
            this.lblTimeClock.Name = "lblTimeClock";
            this.lblTimeClock.Size = new System.Drawing.Size(30, 13);
            this.lblTimeClock.TabIndex = 80;
            this.lblTimeClock.Text = "Time";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 741);
            this.Controls.Add(this.lblTimeClock);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.lblFeatures);
            this.Controls.Add(this.lblContactTracing);
            this.Controls.Add(this.lblSearchMovie);
            this.Controls.Add(this.lblUpdateMov);
            this.Controls.Add(this.lblAddMov);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblSocialDistancing);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.lblMovie);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblSocialDistancing;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblAddMov;
        private System.Windows.Forms.Label lblUpdateMov;
        private System.Windows.Forms.Label lblSearchMovie;
        private System.Windows.Forms.Label lblContactTracing;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblTimeClock;
    }
}