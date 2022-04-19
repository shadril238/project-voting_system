namespace VotingSystemApplication.Presentation_Layer
{
    partial class frm_VotingDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_VotingDashboard));
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.pnl_voteOption = new System.Windows.Forms.Panel();
            this.pictureBox_windowclosingReg = new System.Windows.Forms.PictureBox();
            this.lbl_back = new System.Windows.Forms.Label();
            this.pictureBox_backtouserdashboard = new System.Windows.Forms.PictureBox();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtouserdashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_1.Controls.Add(this.lbl_welcome);
            this.pnl_1.Controls.Add(this.pnl_voteOption);
            this.pnl_1.Controls.Add(this.pictureBox_windowclosingReg);
            this.pnl_1.Location = new System.Drawing.Point(249, -1);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(814, 674);
            this.pnl_1.TabIndex = 1;
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_welcome.Location = new System.Drawing.Point(458, 32);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(0, 19);
            this.lbl_welcome.TabIndex = 46;
            // 
            // pnl_voteOption
            // 
            this.pnl_voteOption.Location = new System.Drawing.Point(33, 73);
            this.pnl_voteOption.Name = "pnl_voteOption";
            this.pnl_voteOption.Size = new System.Drawing.Size(730, 559);
            this.pnl_voteOption.TabIndex = 45;
            // 
            // pictureBox_windowclosingReg
            // 
            this.pictureBox_windowclosingReg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_windowclosingReg.Image")));
            this.pictureBox_windowclosingReg.Location = new System.Drawing.Point(728, 3);
            this.pictureBox_windowclosingReg.Name = "pictureBox_windowclosingReg";
            this.pictureBox_windowclosingReg.Size = new System.Drawing.Size(57, 64);
            this.pictureBox_windowclosingReg.TabIndex = 44;
            this.pictureBox_windowclosingReg.TabStop = false;
            this.pictureBox_windowclosingReg.Click += new System.EventHandler(this.pictureBox_windowclosingReg_Click);
            // 
            // lbl_back
            // 
            this.lbl_back.AutoSize = true;
            this.lbl_back.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_back.ForeColor = System.Drawing.Color.Black;
            this.lbl_back.Location = new System.Drawing.Point(83, 625);
            this.lbl_back.Name = "lbl_back";
            this.lbl_back.Size = new System.Drawing.Size(0, 18);
            this.lbl_back.TabIndex = 45;
            // 
            // pictureBox_backtouserdashboard
            // 
            this.pictureBox_backtouserdashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_backtouserdashboard.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_backtouserdashboard.Image")));
            this.pictureBox_backtouserdashboard.Location = new System.Drawing.Point(29, 616);
            this.pictureBox_backtouserdashboard.Name = "pictureBox_backtouserdashboard";
            this.pictureBox_backtouserdashboard.Size = new System.Drawing.Size(50, 34);
            this.pictureBox_backtouserdashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_backtouserdashboard.TabIndex = 44;
            this.pictureBox_backtouserdashboard.TabStop = false;
            this.pictureBox_backtouserdashboard.Click += new System.EventHandler(this.pictureBox_backtouserdashboard_Click);
            // 
            // frm_VotingDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.lbl_back);
            this.Controls.Add(this.pictureBox_backtouserdashboard);
            this.Controls.Add(this.pnl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_VotingDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VotingDashboard";
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtouserdashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Panel pnl_voteOption;
        private System.Windows.Forms.PictureBox pictureBox_windowclosingReg;
        private System.Windows.Forms.Label lbl_back;
        private System.Windows.Forms.PictureBox pictureBox_backtouserdashboard;
    }
}