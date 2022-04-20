namespace VotingSystemApplication.Presentation_Layer
{
    partial class txt_CandidateRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txt_CandidateRegistration));
            this.pictureBox_windowclosingReg = new System.Windows.Forms.PictureBox();
            this.grpBox_main = new System.Windows.Forms.GroupBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.chkBox_terms = new System.Windows.Forms.CheckBox();
            this.txtBox_party = new System.Windows.Forms.TextBox();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.lbl_backtologin = new System.Windows.Forms.Label();
            this.pictureBox_backtoogin = new System.Windows.Forms.PictureBox();
            this.pictureBox_dp = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).BeginInit();
            this.grpBox_main.SuspendLayout();
            this.pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtoogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_windowclosingReg
            // 
            this.pictureBox_windowclosingReg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_windowclosingReg.Image")));
            this.pictureBox_windowclosingReg.Location = new System.Drawing.Point(991, 4);
            this.pictureBox_windowclosingReg.Name = "pictureBox_windowclosingReg";
            this.pictureBox_windowclosingReg.Size = new System.Drawing.Size(57, 64);
            this.pictureBox_windowclosingReg.TabIndex = 43;
            this.pictureBox_windowclosingReg.TabStop = false;
            this.pictureBox_windowclosingReg.Click += new System.EventHandler(this.pictureBox_windowclosingReg_Click);
            // 
            // grpBox_main
            // 
            this.grpBox_main.Controls.Add(this.btn_register);
            this.grpBox_main.Controls.Add(this.chkBox_terms);
            this.grpBox_main.Controls.Add(this.txtBox_party);
            this.grpBox_main.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox_main.Location = new System.Drawing.Point(282, 80);
            this.grpBox_main.Name = "grpBox_main";
            this.grpBox_main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpBox_main.Size = new System.Drawing.Size(766, 581);
            this.grpBox_main.TabIndex = 42;
            this.grpBox_main.TabStop = false;
            this.grpBox_main.Text = "Candidate Registration";
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_register.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(19, 123);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(129, 45);
            this.btn_register.TabIndex = 16;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // chkBox_terms
            // 
            this.chkBox_terms.AutoSize = true;
            this.chkBox_terms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_terms.ForeColor = System.Drawing.Color.RoyalBlue;
            this.chkBox_terms.Location = new System.Drawing.Point(327, 64);
            this.chkBox_terms.Name = "chkBox_terms";
            this.chkBox_terms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBox_terms.Size = new System.Drawing.Size(312, 27);
            this.chkBox_terms.TabIndex = 17;
            this.chkBox_terms.Text = "I agree to the Privacy Policy.";
            this.chkBox_terms.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkBox_terms.UseVisualStyleBackColor = true;
            this.chkBox_terms.Click += new System.EventHandler(this.chkBox_terms_Click);
            // 
            // txtBox_party
            // 
            this.txtBox_party.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_party.Location = new System.Drawing.Point(19, 60);
            this.txtBox_party.Multiline = true;
            this.txtBox_party.Name = "txtBox_party";
            this.txtBox_party.Size = new System.Drawing.Size(279, 41);
            this.txtBox_party.TabIndex = 0;
            this.txtBox_party.Text = "Candidate Party";
            this.txtBox_party.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //this.txtBox_party.TextChanged += new System.EventHandler(this.txtBox_party_TextChanged);
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_left.Controls.Add(this.lbl_backtologin);
            this.pnl_left.Controls.Add(this.pictureBox_backtoogin);
            this.pnl_left.Controls.Add(this.pictureBox_dp);
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(250, 674);
            this.pnl_left.TabIndex = 41;
            // 
            // lbl_backtologin
            // 
            this.lbl_backtologin.AutoSize = true;
            this.lbl_backtologin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_backtologin.ForeColor = System.Drawing.Color.White;
            this.lbl_backtologin.Location = new System.Drawing.Point(85, 611);
            this.lbl_backtologin.Name = "lbl_backtologin";
            this.lbl_backtologin.Size = new System.Drawing.Size(0, 18);
            this.lbl_backtologin.TabIndex = 41;
            // 
            // pictureBox_backtoogin
            // 
            this.pictureBox_backtoogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_backtoogin.Image")));
            this.pictureBox_backtoogin.Location = new System.Drawing.Point(31, 602);
            this.pictureBox_backtoogin.Name = "pictureBox_backtoogin";
            this.pictureBox_backtoogin.Size = new System.Drawing.Size(50, 34);
            this.pictureBox_backtoogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_backtoogin.TabIndex = 40;
            this.pictureBox_backtoogin.TabStop = false;
            // 
            // pictureBox_dp
            // 
            this.pictureBox_dp.Location = new System.Drawing.Point(31, 255);
            this.pictureBox_dp.Name = "pictureBox_dp";
            this.pictureBox_dp.Size = new System.Drawing.Size(199, 140);
            this.pictureBox_dp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_dp.TabIndex = 2;
            this.pictureBox_dp.TabStop = false;
            // 
            // txt_CandidateRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.pictureBox_windowclosingReg);
            this.Controls.Add(this.grpBox_main);
            this.Controls.Add(this.pnl_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "txt_CandidateRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandidateRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).EndInit();
            this.grpBox_main.ResumeLayout(false);
            this.grpBox_main.PerformLayout();
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtoogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_windowclosingReg;
        private System.Windows.Forms.GroupBox grpBox_main;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.CheckBox chkBox_terms;
        private System.Windows.Forms.TextBox txtBox_party;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Label lbl_backtologin;
        private System.Windows.Forms.PictureBox pictureBox_backtoogin;
        private System.Windows.Forms.PictureBox pictureBox_dp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}