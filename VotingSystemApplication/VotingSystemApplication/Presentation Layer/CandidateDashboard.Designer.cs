namespace VotingSystemApplication.Presentation_Layer
{
    partial class frm_CandidateDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CandidateDashboard));
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.pictureBox_windowclosingReg = new System.Windows.Forms.PictureBox();
            this.btn_voteresult = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_backtologin = new System.Windows.Forms.Label();
            this.pictureBox_backtologin = new System.Windows.Forms.PictureBox();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtologin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_1.Controls.Add(this.lbl_welcome);
            this.pnl_1.Controls.Add(this.pictureBox_windowclosingReg);
            this.pnl_1.Location = new System.Drawing.Point(264, 0);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(798, 674);
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
            // pictureBox_windowclosingReg
            // 
            this.pictureBox_windowclosingReg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_windowclosingReg.Image")));
            this.pictureBox_windowclosingReg.Location = new System.Drawing.Point(728, 3);
            this.pictureBox_windowclosingReg.Name = "pictureBox_windowclosingReg";
            this.pictureBox_windowclosingReg.Size = new System.Drawing.Size(57, 64);
            this.pictureBox_windowclosingReg.TabIndex = 44;
            this.pictureBox_windowclosingReg.TabStop = false;
            // 
            // btn_voteresult
            // 
            this.btn_voteresult.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voteresult.Location = new System.Drawing.Point(44, 284);
            this.btn_voteresult.Name = "btn_voteresult";
            this.btn_voteresult.Size = new System.Drawing.Size(182, 81);
            this.btn_voteresult.TabIndex = 48;
            this.btn_voteresult.Text = "Show Vote Result";
            this.btn_voteresult.UseVisualStyleBackColor = true;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(3, 32);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(261, 27);
            this.lbl_1.TabIndex = 50;
            this.lbl_1.Text = "CandiDate Dashboard";
            // 
            // lbl_backtologin
            // 
            this.lbl_backtologin.AutoSize = true;
            this.lbl_backtologin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_backtologin.ForeColor = System.Drawing.Color.Black;
            this.lbl_backtologin.Location = new System.Drawing.Point(98, 636);
            this.lbl_backtologin.Name = "lbl_backtologin";
            this.lbl_backtologin.Size = new System.Drawing.Size(69, 18);
            this.lbl_backtologin.TabIndex = 52;
            this.lbl_backtologin.Text = "Sign Out";
            // 
            // pictureBox_backtologin
            // 
            this.pictureBox_backtologin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_backtologin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_backtologin.Image")));
            this.pictureBox_backtologin.Location = new System.Drawing.Point(44, 627);
            this.pictureBox_backtologin.Name = "pictureBox_backtologin";
            this.pictureBox_backtologin.Size = new System.Drawing.Size(50, 34);
            this.pictureBox_backtologin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_backtologin.TabIndex = 51;
            this.pictureBox_backtologin.TabStop = false;
            // 
            // frm_CandidateDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.lbl_backtologin);
            this.Controls.Add(this.pictureBox_backtologin);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_voteresult);
            this.Controls.Add(this.pnl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CandidateDashboard";
            this.Text = "CandidateDashboard";
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtologin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.PictureBox pictureBox_windowclosingReg;
        private System.Windows.Forms.Button btn_voteresult;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_backtologin;
        private System.Windows.Forms.PictureBox pictureBox_backtologin;
    }
}