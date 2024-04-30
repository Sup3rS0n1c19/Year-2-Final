namespace Riget_Zoo_Adventures
{
    partial class frmZooInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZooInformation));
            this.lblRigetZooAdventures = new System.Windows.Forms.Label();
            this.lblZooTimes = new System.Windows.Forms.Label();
            this.lblWeekDayTimes = new System.Windows.Forms.Label();
            this.lblWeekendTimes = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAnimalInformation = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnBookTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRigetZooAdventures
            // 
            this.lblRigetZooAdventures.AutoSize = true;
            this.lblRigetZooAdventures.Font = new System.Drawing.Font("Malgun Gothic", 40F);
            this.lblRigetZooAdventures.ForeColor = System.Drawing.Color.White;
            this.lblRigetZooAdventures.Location = new System.Drawing.Point(84, 12);
            this.lblRigetZooAdventures.Name = "lblRigetZooAdventures";
            this.lblRigetZooAdventures.Size = new System.Drawing.Size(566, 72);
            this.lblRigetZooAdventures.TabIndex = 16;
            this.lblRigetZooAdventures.Text = "Riget Zoo Adventures";
            // 
            // lblZooTimes
            // 
            this.lblZooTimes.AutoSize = true;
            this.lblZooTimes.Font = new System.Drawing.Font("Malgun Gothic", 30F);
            this.lblZooTimes.ForeColor = System.Drawing.Color.White;
            this.lblZooTimes.Location = new System.Drawing.Point(55, 222);
            this.lblZooTimes.Name = "lblZooTimes";
            this.lblZooTimes.Size = new System.Drawing.Size(325, 54);
            this.lblZooTimes.TabIndex = 17;
            this.lblZooTimes.Text = "Zoo Open Times";
            // 
            // lblWeekDayTimes
            // 
            this.lblWeekDayTimes.AutoSize = true;
            this.lblWeekDayTimes.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.lblWeekDayTimes.ForeColor = System.Drawing.Color.White;
            this.lblWeekDayTimes.Location = new System.Drawing.Point(55, 333);
            this.lblWeekDayTimes.Name = "lblWeekDayTimes";
            this.lblWeekDayTimes.Size = new System.Drawing.Size(356, 37);
            this.lblWeekDayTimes.TabIndex = 18;
            this.lblWeekDayTimes.Text = "Week Days - 10:00 to 18:00";
            // 
            // lblWeekendTimes
            // 
            this.lblWeekendTimes.AutoSize = true;
            this.lblWeekendTimes.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.lblWeekendTimes.ForeColor = System.Drawing.Color.White;
            this.lblWeekendTimes.Location = new System.Drawing.Point(57, 398);
            this.lblWeekendTimes.Name = "lblWeekendTimes";
            this.lblWeekendTimes.Size = new System.Drawing.Size(332, 37);
            this.lblWeekendTimes.TabIndex = 19;
            this.lblWeekendTimes.Text = "Weekends - 9:00 to 17:30";
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
            this.btnGoBack.TabIndex = 20;
            this.btnGoBack.Text = "Click here to go back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
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
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAnimalInformation
            // 
            this.btnAnimalInformation.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAnimalInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimalInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnimalInformation.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.btnAnimalInformation.ForeColor = System.Drawing.Color.White;
            this.btnAnimalInformation.Location = new System.Drawing.Point(744, 548);
            this.btnAnimalInformation.Name = "btnAnimalInformation";
            this.btnAnimalInformation.Size = new System.Drawing.Size(164, 95);
            this.btnAnimalInformation.TabIndex = 22;
            this.btnAnimalInformation.Text = "Click here for information on animals";
            this.btnAnimalInformation.UseVisualStyleBackColor = false;
            this.btnAnimalInformation.Click += new System.EventHandler(this.btnAnimalInformation_Click);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(88, 90);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 23;
            this.picLogo.TabStop = false;
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBookTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookTicket.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.btnBookTicket.ForeColor = System.Drawing.Color.White;
            this.btnBookTicket.Location = new System.Drawing.Point(118, 503);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(119, 94);
            this.btnBookTicket.TabIndex = 29;
            this.btnBookTicket.Text = "Click here to make a booking";
            this.btnBookTicket.UseVisualStyleBackColor = false;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // frmZooInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1273, 735);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnAnimalInformation);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lblWeekendTimes);
            this.Controls.Add(this.lblWeekDayTimes);
            this.Controls.Add(this.lblZooTimes);
            this.Controls.Add(this.lblRigetZooAdventures);
            this.Name = "frmZooInformation";
            this.Text = "Zoo Information";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRigetZooAdventures;
        private System.Windows.Forms.Label lblZooTimes;
        private System.Windows.Forms.Label lblWeekDayTimes;
        private System.Windows.Forms.Label lblWeekendTimes;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAnimalInformation;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnBookTicket;
    }
}