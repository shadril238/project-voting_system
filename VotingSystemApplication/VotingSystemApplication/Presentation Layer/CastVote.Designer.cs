namespace VotingSystemApplication.Presentation_Layer
{
    partial class CastVote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CastVote));
            this.pictureBox_windowclosingReg = new System.Windows.Forms.PictureBox();
            this.pictureBox_backtoogin = new System.Windows.Forms.PictureBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtoogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_windowclosingReg
            // 
            this.pictureBox_windowclosingReg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_windowclosingReg.Image")));
            this.pictureBox_windowclosingReg.Location = new System.Drawing.Point(975, 3);
            this.pictureBox_windowclosingReg.Name = "pictureBox_windowclosingReg";
            this.pictureBox_windowclosingReg.Size = new System.Drawing.Size(57, 64);
            this.pictureBox_windowclosingReg.TabIndex = 45;
            this.pictureBox_windowclosingReg.TabStop = false;
            this.pictureBox_windowclosingReg.Click += new System.EventHandler(this.pictureBox_windowclosingReg_Click);
            // 
            // pictureBox_backtoogin
            // 
            this.pictureBox_backtoogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_backtoogin.Image")));
            this.pictureBox_backtoogin.Location = new System.Drawing.Point(12, 580);
            this.pictureBox_backtoogin.Name = "pictureBox_backtoogin";
            this.pictureBox_backtoogin.Size = new System.Drawing.Size(50, 34);
            this.pictureBox_backtoogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_backtoogin.TabIndex = 46;
            this.pictureBox_backtoogin.TabStop = false;
            this.pictureBox_backtoogin.Click += new System.EventHandler(this.pictureBox_backtoogin_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(127, 160);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(329, 40);
            this.lbl_1.TabIndex = 47;
            this.lbl_1.Text = "Total Vote Casted :";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.Location = new System.Drawing.Point(127, 296);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(329, 40);
            this.lbl_3.TabIndex = 48;
            this.lbl_3.Text = "Total Vote Casted :";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.Location = new System.Drawing.Point(127, 227);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(329, 40);
            this.lbl_2.TabIndex = 49;
            this.lbl_2.Text = "Total Vote Casted :";
            // 
            // CastVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 626);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.pictureBox_backtoogin);
            this.Controls.Add(this.pictureBox_windowclosingReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CastVote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CastVote";
            this.Load += new System.EventHandler(this.CastVote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtoogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_windowclosingReg;
        private System.Windows.Forms.PictureBox pictureBox_backtoogin;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_2;
    }
}