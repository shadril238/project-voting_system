using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystemApplication.Presentation_Layer
{
    public partial class frm_VotingDashboard : Form
    {
        public frm_VotingDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox_windowclosingReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_backtouserdashboard_Click(object sender, EventArgs e)
        {
            //back to vote dashboard to user dashboard
            frm_UserDashboard user=new frm_UserDashboard();
            user.Show();
            this.Hide();
        }
    }
}
