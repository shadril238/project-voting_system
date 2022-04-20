using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemApplication.Presentation_Layer;

namespace VotingSystemApplication.Data_Access_Layer
{
    public partial class frm_AdminDashboard : Form
    {
        public frm_AdminDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox_windowclosingReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_enablevote_Click(object sender, EventArgs e)
        {
            AdminDataAccess.enableVote=true;
        }

        private void pictureBox_backtologin_Click(object sender, EventArgs e)
        {
            //sign out
            frm_LogIn login = new frm_LogIn();
            login.Show();
            this.Hide();
        }

        private void btn_disablevote_Click(object sender, EventArgs e)
        {
            AdminDataAccess.enableVote = false;
        }

        public void RefreshDataGridView()
        {
            UserDataAccess data1 = new UserDataAccess();
            dataGridView_verified.DataSource = data1.VerifiedUsers();
            UserDataAccess data2 = new UserDataAccess();
            dataGridView_unverified.DataSource = data2.UnverifiedUsers();
            UserDataAccess data3 = new UserDataAccess();
            dataGridView_candidates.DataSource = data3.CandidatesList();
            UserDataAccess data4 = new UserDataAccess();
            dataGridView_candidates.DataSource = data3.CandidatesList();

        }
        private void frm_AdminDashboard_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            AdminDataAccess adminDataAccess = new AdminDataAccess();
            if (adminDataAccess.VerifyUser(Convert.ToInt32(txt_userid.Text)))
            {
                RefreshDataGridView();
                MessageBox.Show("Verification Successful");
            }
            else
            {
                MessageBox.Show("Verify Error");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            AdminDataAccess adminDataAccess = new AdminDataAccess();
            if (adminDataAccess.RemoveCandidate(Convert.ToInt32(txt_candidateid.Text)))
            {
                RefreshDataGridView();
                MessageBox.Show("Successfully Removed!");
            }
            else
            {
                MessageBox.Show("Operation Unsuccessful!");
            }

        }

        private void btn_voteresult_Click(object sender, EventArgs e)
        {
            new CastVote().Show();
            this.Hide();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo);
            AdminDataAccess admin=new AdminDataAccess();
            if (admin.DeleteFakeUsers(Convert.ToInt32(txt_userid.Text)))
            {
                MessageBox.Show("Successfully Deleted!");
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }
    }
}
