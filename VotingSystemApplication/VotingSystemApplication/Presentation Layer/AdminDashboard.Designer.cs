namespace VotingSystemApplication.Data_Access_Layer
{
    partial class frm_AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AdminDashboard));
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.btn_del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.txt_candidateid = new System.Windows.Forms.TextBox();
            this.btn_verify = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.grpbox_candidates = new System.Windows.Forms.GroupBox();
            this.dataGridView_candidates = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.grpbox_unverifiedusers = new System.Windows.Forms.GroupBox();
            this.dataGridView_unverified = new System.Windows.Forms.DataGridView();
            this.grpbox_verifieduser = new System.Windows.Forms.GroupBox();
            this.dataGridView_verified = new System.Windows.Forms.DataGridView();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.pictureBox_windowclosingReg = new System.Windows.Forms.PictureBox();
            this.lbl_backtologin = new System.Windows.Forms.Label();
            this.pictureBox_backtologin = new System.Windows.Forms.PictureBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_enablevote = new System.Windows.Forms.Button();
            this.btn_voteresult = new System.Windows.Forms.Button();
            this.btn_disablevote = new System.Windows.Forms.Button();
            this.pnl_1.SuspendLayout();
            this.grpbox_candidates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_candidates)).BeginInit();
            this.grpbox_unverifiedusers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_unverified)).BeginInit();
            this.grpbox_verifieduser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_verified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtologin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_1.Controls.Add(this.btn_del);
            this.pnl_1.Controls.Add(this.label1);
            this.pnl_1.Controls.Add(this.btn_remove);
            this.pnl_1.Controls.Add(this.txt_candidateid);
            this.pnl_1.Controls.Add(this.btn_verify);
            this.pnl_1.Controls.Add(this.lbl_id);
            this.pnl_1.Controls.Add(this.grpbox_candidates);
            this.pnl_1.Controls.Add(this.txt_userid);
            this.pnl_1.Controls.Add(this.grpbox_unverifiedusers);
            this.pnl_1.Controls.Add(this.grpbox_verifieduser);
            this.pnl_1.Controls.Add(this.lbl_welcome);
            this.pnl_1.Controls.Add(this.pictureBox_windowclosingReg);
            this.pnl_1.Location = new System.Drawing.Point(264, -1);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(798, 674);
            this.pnl_1.TabIndex = 53;
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.White;
            this.btn_del.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(553, 378);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(190, 33);
            this.btn_del.TabIndex = 71;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 70;
            this.label1.Text = "User ID";
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.White;
            this.btn_remove.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(341, 589);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(190, 33);
            this.btn_remove.TabIndex = 69;
            this.btn_remove.Text = "Remove Candidate";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // txt_candidateid
            // 
            this.txt_candidateid.Location = new System.Drawing.Point(115, 589);
            this.txt_candidateid.Multiline = true;
            this.txt_candidateid.Name = "txt_candidateid";
            this.txt_candidateid.Size = new System.Drawing.Size(180, 32);
            this.txt_candidateid.TabIndex = 67;
            // 
            // btn_verify
            // 
            this.btn_verify.BackColor = System.Drawing.Color.White;
            this.btn_verify.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verify.Location = new System.Drawing.Point(341, 379);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(190, 33);
            this.btn_verify.TabIndex = 66;
            this.btn_verify.Text = "Verify";
            this.btn_verify.UseVisualStyleBackColor = false;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(22, 384);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(87, 27);
            this.lbl_id.TabIndex = 63;
            this.lbl_id.Text = "User ID";
            // 
            // grpbox_candidates
            // 
            this.grpbox_candidates.Controls.Add(this.dataGridView_candidates);
            this.grpbox_candidates.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_candidates.Location = new System.Drawing.Point(27, 433);
            this.grpbox_candidates.Name = "grpbox_candidates";
            this.grpbox_candidates.Size = new System.Drawing.Size(716, 149);
            this.grpbox_candidates.TabIndex = 62;
            this.grpbox_candidates.TabStop = false;
            this.grpbox_candidates.Text = "Candidates";
            // 
            // dataGridView_candidates
            // 
            this.dataGridView_candidates.AllowUserToAddRows = false;
            this.dataGridView_candidates.AllowUserToDeleteRows = false;
            this.dataGridView_candidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_candidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView_candidates.Location = new System.Drawing.Point(3, 23);
            this.dataGridView_candidates.Name = "dataGridView_candidates";
            this.dataGridView_candidates.ReadOnly = true;
            this.dataGridView_candidates.RowHeadersWidth = 51;
            this.dataGridView_candidates.RowTemplate.Height = 24;
            this.dataGridView_candidates.Size = new System.Drawing.Size(713, 120);
            this.dataGridView_candidates.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "userid";
            this.Column1.HeaderText = "CandidatesId";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(115, 379);
            this.txt_userid.Multiline = true;
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(180, 32);
            this.txt_userid.TabIndex = 0;
            // 
            // grpbox_unverifiedusers
            // 
            this.grpbox_unverifiedusers.Controls.Add(this.dataGridView_unverified);
            this.grpbox_unverifiedusers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_unverifiedusers.Location = new System.Drawing.Point(27, 211);
            this.grpbox_unverifiedusers.Name = "grpbox_unverifiedusers";
            this.grpbox_unverifiedusers.Size = new System.Drawing.Size(716, 149);
            this.grpbox_unverifiedusers.TabIndex = 61;
            this.grpbox_unverifiedusers.TabStop = false;
            this.grpbox_unverifiedusers.Text = "Unverified Users";
            // 
            // dataGridView_unverified
            // 
            this.dataGridView_unverified.AllowUserToAddRows = false;
            this.dataGridView_unverified.AllowUserToDeleteRows = false;
            this.dataGridView_unverified.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_unverified.Location = new System.Drawing.Point(3, 23);
            this.dataGridView_unverified.Name = "dataGridView_unverified";
            this.dataGridView_unverified.ReadOnly = true;
            this.dataGridView_unverified.RowHeadersWidth = 51;
            this.dataGridView_unverified.RowTemplate.Height = 24;
            this.dataGridView_unverified.Size = new System.Drawing.Size(713, 120);
            this.dataGridView_unverified.TabIndex = 1;
            // 
            // grpbox_verifieduser
            // 
            this.grpbox_verifieduser.Controls.Add(this.dataGridView_verified);
            this.grpbox_verifieduser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_verifieduser.Location = new System.Drawing.Point(27, 54);
            this.grpbox_verifieduser.Name = "grpbox_verifieduser";
            this.grpbox_verifieduser.Size = new System.Drawing.Size(716, 138);
            this.grpbox_verifieduser.TabIndex = 60;
            this.grpbox_verifieduser.TabStop = false;
            this.grpbox_verifieduser.Text = "Verified Users";
            // 
            // dataGridView_verified
            // 
            this.dataGridView_verified.AllowUserToAddRows = false;
            this.dataGridView_verified.AllowUserToDeleteRows = false;
            this.dataGridView_verified.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_verified.Location = new System.Drawing.Point(3, 19);
            this.dataGridView_verified.Name = "dataGridView_verified";
            this.dataGridView_verified.ReadOnly = true;
            this.dataGridView_verified.RowHeadersWidth = 51;
            this.dataGridView_verified.RowTemplate.Height = 24;
            this.dataGridView_verified.Size = new System.Drawing.Size(713, 113);
            this.dataGridView_verified.TabIndex = 0;
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
            this.pictureBox_windowclosingReg.Location = new System.Drawing.Point(736, 3);
            this.pictureBox_windowclosingReg.Name = "pictureBox_windowclosingReg";
            this.pictureBox_windowclosingReg.Size = new System.Drawing.Size(57, 64);
            this.pictureBox_windowclosingReg.TabIndex = 44;
            this.pictureBox_windowclosingReg.TabStop = false;
            this.pictureBox_windowclosingReg.Click += new System.EventHandler(this.pictureBox_windowclosingReg_Click);
            // 
            // lbl_backtologin
            // 
            this.lbl_backtologin.AutoSize = true;
            this.lbl_backtologin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_backtologin.ForeColor = System.Drawing.Color.Black;
            this.lbl_backtologin.Location = new System.Drawing.Point(96, 621);
            this.lbl_backtologin.Name = "lbl_backtologin";
            this.lbl_backtologin.Size = new System.Drawing.Size(69, 18);
            this.lbl_backtologin.TabIndex = 59;
            this.lbl_backtologin.Text = "Sign Out";
            // 
            // pictureBox_backtologin
            // 
            this.pictureBox_backtologin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_backtologin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_backtologin.Image")));
            this.pictureBox_backtologin.Location = new System.Drawing.Point(42, 612);
            this.pictureBox_backtologin.Name = "pictureBox_backtologin";
            this.pictureBox_backtologin.Size = new System.Drawing.Size(50, 34);
            this.pictureBox_backtologin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_backtologin.TabIndex = 58;
            this.pictureBox_backtologin.TabStop = false;
            this.pictureBox_backtologin.Click += new System.EventHandler(this.pictureBox_backtologin_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(12, 9);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(214, 27);
            this.lbl_1.TabIndex = 57;
            this.lbl_1.Text = "Admin Dashboard";
            // 
            // btn_enablevote
            // 
            this.btn_enablevote.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enablevote.Location = new System.Drawing.Point(42, 163);
            this.btn_enablevote.Name = "btn_enablevote";
            this.btn_enablevote.Size = new System.Drawing.Size(182, 79);
            this.btn_enablevote.TabIndex = 56;
            this.btn_enablevote.Text = "Enable Vote";
            this.btn_enablevote.UseVisualStyleBackColor = true;
            this.btn_enablevote.Click += new System.EventHandler(this.btn_enablevote_Click);
            // 
            // btn_voteresult
            // 
            this.btn_voteresult.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voteresult.Location = new System.Drawing.Point(42, 397);
            this.btn_voteresult.Name = "btn_voteresult";
            this.btn_voteresult.Size = new System.Drawing.Size(182, 81);
            this.btn_voteresult.TabIndex = 55;
            this.btn_voteresult.Text = "Show Vote Result";
            this.btn_voteresult.UseVisualStyleBackColor = true;
            this.btn_voteresult.Click += new System.EventHandler(this.btn_voteresult_Click);
            // 
            // btn_disablevote
            // 
            this.btn_disablevote.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disablevote.Location = new System.Drawing.Point(42, 280);
            this.btn_disablevote.Name = "btn_disablevote";
            this.btn_disablevote.Size = new System.Drawing.Size(182, 79);
            this.btn_disablevote.TabIndex = 54;
            this.btn_disablevote.Text = "Disable Vote";
            this.btn_disablevote.UseVisualStyleBackColor = true;
            this.btn_disablevote.Click += new System.EventHandler(this.btn_disablevote_Click);
            // 
            // frm_AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.pnl_1);
            this.Controls.Add(this.lbl_backtologin);
            this.Controls.Add(this.pictureBox_backtologin);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_enablevote);
            this.Controls.Add(this.btn_voteresult);
            this.Controls.Add(this.btn_disablevote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.frm_AdminDashboard_Load);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            this.grpbox_candidates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_candidates)).EndInit();
            this.grpbox_unverifiedusers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_unverified)).EndInit();
            this.grpbox_verifieduser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_verified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtologin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.PictureBox pictureBox_windowclosingReg;
        private System.Windows.Forms.Label lbl_backtologin;
        private System.Windows.Forms.PictureBox pictureBox_backtologin;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_enablevote;
        private System.Windows.Forms.Button btn_voteresult;
        private System.Windows.Forms.Button btn_disablevote;
        private System.Windows.Forms.GroupBox grpbox_candidates;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.GroupBox grpbox_unverifiedusers;
        private System.Windows.Forms.GroupBox grpbox_verifieduser;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.DataGridView dataGridView_verified;
        private System.Windows.Forms.DataGridView dataGridView_unverified;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox txt_candidateid;
        private System.Windows.Forms.DataGridView dataGridView_candidates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_del;
    }
}