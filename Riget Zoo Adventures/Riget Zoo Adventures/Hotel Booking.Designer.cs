namespace Riget_Zoo_Adventures
{
    partial class frmHotelBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHotelBooking));
            this.lblRigetZooAdventures = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.calStartDate = new System.Windows.Forms.MonthCalendar();
            this.calEndDate = new System.Windows.Forms.MonthCalendar();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picHidePassword = new System.Windows.Forms.PictureBox();
            this.picShowPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRigetZooAdventures
            // 
            this.lblRigetZooAdventures.AutoSize = true;
            this.lblRigetZooAdventures.BackColor = System.Drawing.Color.Transparent;
            this.lblRigetZooAdventures.Font = new System.Drawing.Font("Malgun Gothic", 40F);
            this.lblRigetZooAdventures.ForeColor = System.Drawing.Color.White;
            this.lblRigetZooAdventures.Location = new System.Drawing.Point(84, 12);
            this.lblRigetZooAdventures.Name = "lblRigetZooAdventures";
            this.lblRigetZooAdventures.Size = new System.Drawing.Size(566, 72);
            this.lblRigetZooAdventures.TabIndex = 18;
            this.lblRigetZooAdventures.Text = "Riget Zoo Adventures";
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(88, 90);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 17;
            this.picLogo.TabStop = false;
            // 
            // calStartDate
            // 
            this.calStartDate.Location = new System.Drawing.Point(373, 170);
            this.calStartDate.Name = "calStartDate";
            this.calStartDate.ShowToday = false;
            this.calStartDate.ShowTodayCircle = false;
            this.calStartDate.TabIndex = 19;
            // 
            // calEndDate
            // 
            this.calEndDate.Location = new System.Drawing.Point(865, 170);
            this.calEndDate.Name = "calEndDate";
            this.calEndDate.ShowToday = false;
            this.calEndDate.ShowTodayCircle = false;
            this.calEndDate.TabIndex = 20;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Malgun Gothic", 30F);
            this.lblStartDate.ForeColor = System.Drawing.Color.White;
            this.lblStartDate.Location = new System.Drawing.Point(383, 107);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(207, 54);
            this.lblStartDate.TabIndex = 21;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Malgun Gothic", 30F);
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(875, 107);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(190, 54);
            this.lblEndDate.TabIndex = 22;
            this.lblEndDate.Text = "End Date";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoBack.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(12, 658);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(126, 65);
            this.btnGoBack.TabIndex = 23;
            this.btnGoBack.Text = "Click here to go back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.BackColor = System.Drawing.Color.YellowGreen;
            this.btnMakeBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeBooking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakeBooking.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.btnMakeBooking.ForeColor = System.Drawing.Color.White;
            this.btnMakeBooking.Location = new System.Drawing.Point(664, 639);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(126, 65);
            this.btnMakeBooking.TabIndex = 24;
            this.btnMakeBooking.Text = "Make Booking";
            this.btnMakeBooking.UseVisualStyleBackColor = false;
            this.btnMakeBooking.Click += new System.EventHandler(this.btbMakeBooking_Click);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.txtCardNumber.Location = new System.Drawing.Point(630, 582);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(202, 34);
            this.txtCardNumber.TabIndex = 25;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.lblCardNumber.ForeColor = System.Drawing.Color.White;
            this.lblCardNumber.Location = new System.Drawing.Point(634, 551);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(198, 28);
            this.lblCardNumber.TabIndex = 26;
            this.lblCardNumber.Text = "Credit Card Number";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(634, 464);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 28);
            this.lblPassword.TabIndex = 28;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.txtPassword.Location = new System.Drawing.Point(630, 495);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(202, 34);
            this.txtPassword.TabIndex = 27;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(634, 381);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(104, 28);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.txtUsername.Location = new System.Drawing.Point(630, 412);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(202, 34);
            this.txtUsername.TabIndex = 29;
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.lblRoomId.ForeColor = System.Drawing.Color.White;
            this.lblRoomId.Location = new System.Drawing.Point(634, 302);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(148, 28);
            this.lblRoomId.TabIndex = 32;
            this.lblRoomId.Text = "Room Number";
            // 
            // txtRoomId
            // 
            this.txtRoomId.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.txtRoomId.Location = new System.Drawing.Point(630, 333);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(202, 34);
            this.txtRoomId.TabIndex = 31;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Orange;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1135, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 65);
            this.btnLogout.TabIndex = 33;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picHidePassword
            // 
            this.picHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("picHidePassword.Image")));
            this.picHidePassword.Location = new System.Drawing.Point(838, 495);
            this.picHidePassword.Name = "picHidePassword";
            this.picHidePassword.Size = new System.Drawing.Size(42, 34);
            this.picHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHidePassword.TabIndex = 35;
            this.picHidePassword.TabStop = false;
            this.picHidePassword.Visible = false;
            this.picHidePassword.Click += new System.EventHandler(this.picHidePassword_Click);
            // 
            // picShowPassword
            // 
            this.picShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("picShowPassword.Image")));
            this.picShowPassword.Location = new System.Drawing.Point(838, 495);
            this.picShowPassword.Name = "picShowPassword";
            this.picShowPassword.Size = new System.Drawing.Size(42, 34);
            this.picShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowPassword.TabIndex = 34;
            this.picShowPassword.TabStop = false;
            this.picShowPassword.Click += new System.EventHandler(this.picShowPassword_Click);
            // 
            // frmHotelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1273, 735);
            this.Controls.Add(this.picHidePassword);
            this.Controls.Add(this.picShowPassword);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblRoomId);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.btnMakeBooking);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.calEndDate);
            this.Controls.Add(this.calStartDate);
            this.Controls.Add(this.lblRigetZooAdventures);
            this.Controls.Add(this.picLogo);
            this.Name = "frmHotelBooking";
            this.Text = "Hotel Booking";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRigetZooAdventures;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.MonthCalendar calStartDate;
        private System.Windows.Forms.MonthCalendar calEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picHidePassword;
        private System.Windows.Forms.PictureBox picShowPassword;
    }
}