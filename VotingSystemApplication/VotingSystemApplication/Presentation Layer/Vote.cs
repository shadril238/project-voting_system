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
    public partial class Vote : Form
    {
        public Vote()
        {
            InitializeComponent();
        }

        private void btn_c1_Click(object sender, EventArgs e)
        {
            UserDataAccess.candidate1 += 1;
            UserDataAccess.totalVote += 1;
            UserDataAccess data1 = new UserDataAccess();
            UserDataAccess data2 = new UserDataAccess();
            int cnt=data1.ReadVote("Candidate1");
            if(data2.UpdateVote("Candidate1", cnt))
            {
                MessageBox.Show("Vote Submitted!");
            }
            else
            {
                MessageBox.Show("You are not eligiable!");
            }
            btn_c1.Enabled = false;
            btn_c2.Enabled = false;

        }

        private void btn_c2_Click(object sender, EventArgs e)
        {
            UserDataAccess.candidate2 += 1;
            UserDataAccess.totalVote += 1;
            UserDataAccess data1 = new UserDataAccess();
            UserDataAccess data2 = new UserDataAccess();
            int cnt = data1.ReadVote("Candidate2");
            if (data2.UpdateVote("Candidate2", cnt))
            {
                MessageBox.Show("Vote Submitted!");
            }
            else
            {
                MessageBox.Show("You are not eligiable!");
            }
            btn_c2.Enabled = false;
            btn_c1.Enabled = false;
        }

        private void pictureBox_windowclosingReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_backtoogin_Click(object sender, EventArgs e)
        {
            frm_UserDashboard user=new frm_UserDashboard();
            this.Hide();
            user.Show();
        }
    }
}
