namespace BookingSystem
{
    partial class frmBooking
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
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.cbScreen = new System.Windows.Forms.ComboBox();
            this.cbSched = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // pnlBooking
            // 
            this.pnlBooking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBooking.Location = new System.Drawing.Point(12, 54);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(1199, 500);
            this.pnlBooking.TabIndex = 4;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(1006, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(205, 43);
            this.btnPayment.TabIndex = 13;
            this.btnPayment.Text = "Prooceed to Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // cbScreen
            // 
            this.cbScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbScreen.FormattingEnabled = true;
            this.cbScreen.Items.AddRange(new object[] {
            "Screen 1",
            "Screen 2",
            "Screen 3"});
            this.cbScreen.Location = new System.Drawing.Point(323, 10);
            this.cbScreen.Name = "cbScreen";
            this.cbScreen.Size = new System.Drawing.Size(138, 28);
            this.cbScreen.TabIndex = 14;
            this.cbScreen.SelectedIndexChanged += new System.EventHandler(this.cbScreen_SelectedIndexChanged);
            // 
            // cbSched
            // 
            this.cbSched.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSched.FormattingEnabled = true;
            this.cbSched.Location = new System.Drawing.Point(509, 10);
            this.cbSched.Name = "cbSched";
            this.cbSched.Size = new System.Drawing.Size(184, 28);
            this.cbSched.TabIndex = 18;
            this.cbSched.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 26);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 706);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbSched);
            this.Controls.Add(this.cbScreen);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.pnlBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBooking";
            this.Text = "frmBooking";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.ComboBox cbScreen;
        private System.Windows.Forms.ComboBox cbSched;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}