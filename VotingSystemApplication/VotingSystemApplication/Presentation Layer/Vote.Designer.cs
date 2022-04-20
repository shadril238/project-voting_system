namespace VotingSystemApplication.Presentation_Layer
{
    partial class Vote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vote));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_c2 = new System.Windows.Forms.Button();
            this.btn_c1 = new System.Windows.Forms.Button();
            this.pictureBox_windowclosingReg = new System.Windows.Forms.PictureBox();
            this.pictureBox_backtoogin = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtoogin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_backtoogin);
            this.groupBox1.Controls.Add(this.pictureBox_windowclosingReg);
            this.groupBox1.Controls.Add(this.btn_c2);
            this.groupBox1.Controls.Add(this.btn_c1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 638);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vote";
            // 
            // btn_c2
            // 
            this.btn_c2.Location = new System.Drawing.Point(171, 331);
            this.btn_c2.Name = "btn_c2";
            this.btn_c2.Size = new System.Drawing.Size(255, 122);
            this.btn_c2.TabIndex = 1;
            this.btn_c2.Text = "Candidate2";
            this.btn_c2.UseVisualStyleBackColor = true;
            this.btn_c2.Click += new System.EventHandler(this.btn_c2_Click);
            // 
            // btn_c1
            // 
            this.btn_c1.Location = new System.Drawing.Point(171, 161);
            this.btn_c1.Name = "btn_c1";
            this.btn_c1.Size = new System.Drawing.Size(255, 122);
            this.btn_c1.TabIndex = 0;
            this.btn_c1.Text = "Candidate1";
            this.btn_c1.UseVisualStyleBackColor = true;
            this.btn_c1.Click += new System.EventHandler(this.btn_c1_Click);
            // 
            // pictureBox_windowclosingReg
            // 
            this.pictureBox_windowclosingReg.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_windowclosingReg.Image")));
            this.pictureBox_windowclosingReg.Location = new System.Drawing.Point(971, 0);
            this.pictureBox_windowclosingReg.Name = "pictureBox_windowclosingReg";
            this.pictureBox_windowclosingReg.Size = new System.Drawing.Size(57, 64);
            this.pictureBox_windowclosingReg.TabIndex = 41;
            this.pictureBox_windowclosingReg.TabStop = false;
            this.pictureBox_windowclosingReg.Click += new System.EventHandler(this.pictureBox_windowclosingReg_Click);
            // 
            // pictureBox_backtoogin
            // 
            this.pictureBox_backtoogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_backtoogin.Image")));
            this.pictureBox_backtoogin.Location = new System.Drawing.Point(0, 604);
            this.pictureBox_backtoogin.Name = "pictureBox_backtoogin";
            this.pictureBox_backtoogin.Size = new System.Drawing.Size(50, 34);
            this.pictureBox_backtoogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_backtoogin.TabIndex = 42;
            this.pictureBox_backtoogin.TabStop = false;
            this.pictureBox_backtoogin.Click += new System.EventHandler(this.pictureBox_backtoogin_Click);
            // 
            // Vote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vote";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_windowclosingReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_backtoogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_c2;
        private System.Windows.Forms.Button btn_c1;
        private System.Windows.Forms.PictureBox pictureBox_windowclosingReg;
        private System.Windows.Forms.PictureBox pictureBox_backtoogin;
    }
}