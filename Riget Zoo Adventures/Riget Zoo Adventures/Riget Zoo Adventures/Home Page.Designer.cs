namespace Riget_Zoo_Adventures
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.lblRigetZooAdventures = new System.Windows.Forms.Label();
            this.lblHotelInformation = new System.Windows.Forms.Label();
            this.lblZooInformation = new System.Windows.Forms.Label();
            this.btnHotelInformation = new System.Windows.Forms.Button();
            this.btnZooInformation = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
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
            this.lblRigetZooAdventures.TabIndex = 15;
            this.lblRigetZooAdventures.Text = "Riget Zoo Adventures";
            // 
            // lblHotelInformation
            // 
            this.lblHotelInformation.AutoSize = true;
            this.lblHotelInformation.Font = new System.Drawing.Font("Malgun Gothic", 40F);
            this.lblHotelInformation.ForeColor = System.Drawing.Color.White;
            this.lblHotelInformation.Location = new System.Drawing.Point(12, 270);
            this.lblHotelInformation.Name = "lblHotelInformation";
            this.lblHotelInformation.Size = new System.Drawing.Size(466, 72);
            this.lblHotelInformation.TabIndex = 16;
            this.lblHotelInformation.Text = "Hotel Information";
            // 
            // lblZooInformation
            // 
            this.lblZooInformation.AutoSize = true;
            this.lblZooInformation.Font = new System.Drawing.Font("Malgun Gothic", 40F);
            this.lblZooInformation.ForeColor = System.Drawing.Color.White;
            this.lblZooInformation.Location = new System.Drawing.Point(795, 270);
            this.lblZooInformation.Name = "lblZooInformation";
            this.lblZooInformation.Size = new System.Drawing.Size(429, 72);
            this.lblZooInformation.TabIndex = 17;
            this.lblZooInformation.Text = "Zoo Information";
            // 
            // btnHotelInformation
            // 
            this.btnHotelInformation.BackColor = System.Drawing.Color.YellowGreen;
            this.btnHotelInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHotelInformation.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.btnHotelInformation.ForeColor = System.Drawing.Color.White;
            this.btnHotelInformation.Location = new System.Drawing.Point(200, 616);
            this.btnHotelInformation.Name = "btnHotelInformation";
            this.btnHotelInformation.Size = new System.Drawing.Size(126, 65);
            this.btnHotelInformation.TabIndex = 18;
            this.btnHotelInformation.Text = "Click here for more!";
            this.btnHotelInformation.UseVisualStyleBackColor = false;
            this.btnHotelInformation.Click += new System.EventHandler(this.btnHotelInformation_Click);
            // 
            // btnZooInformation
            // 
            this.btnZooInformation.BackColor = System.Drawing.Color.YellowGreen;
            this.btnZooInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZooInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZooInformation.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this.btnZooInformation.ForeColor = System.Drawing.Color.White;
            this.btnZooInformation.Location = new System.Drawing.Point(962, 616);
            this.btnZooInformation.Name = "btnZooInformation";
            this.btnZooInformation.Size = new System.Drawing.Size(126, 65);
            this.btnZooInformation.TabIndex = 19;
            this.btnZooInformation.Text = "Click here for more!";
            this.btnZooInformation.UseVisualStyleBackColor = false;
            this.btnZooInformation.Click += new System.EventHandler(this.btnZooInformation_Click);
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
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(88, 90);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 21;
            this.picLogo.TabStop = false;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1273, 735);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnZooInformation);
            this.Controls.Add(this.btnHotelInformation);
            this.Controls.Add(this.lblZooInformation);
            this.Controls.Add(this.lblHotelInformation);
            this.Controls.Add(this.lblRigetZooAdventures);
            this.Name = "frmHomePage";
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRigetZooAdventures;
        private System.Windows.Forms.Label lblHotelInformation;
        private System.Windows.Forms.Label lblZooInformation;
        private System.Windows.Forms.Button btnHotelInformation;
        private System.Windows.Forms.Button btnZooInformation;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picLogo;
    }
}