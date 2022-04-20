using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemApplication.Data_Access_Layer;

namespace VotingSystemApplication.Presentation_Layer
{
    public partial class CastVote : Form
    {
        public CastVote()
        {
            InitializeComponent();
        }

        private void pictureBox_windowclosingReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_backtoogin_Click(object sender, EventArgs e)
        {
            frm_AdminDashboard admin = new frm_AdminDashboard();
            admin.Show();
            this.Hide();
        }

        private void CastVote_Load(object sender, EventArgs e)
        {
            lbl_1.Text= "Total Vote Casted :  "+ UserDataAccess.totalVote.ToString();
            lbl_2.Text = "Candidate 1 :  " + UserDataAccess.candidate1.ToString();
            lbl_3.Text = "Candidate 2 :  " + UserDataAccess.candidate2.ToString();
        }
    }
}
