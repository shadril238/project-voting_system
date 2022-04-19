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
    }
}
