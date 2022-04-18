using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemApplication.Entities;

namespace VotingSystemApplication.Presentation_Layer
{
    public partial class frm_UserDashboard : Form
    {
        public frm_UserDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox_windowclosingReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_backtologin_Click(object sender, EventArgs e)
        {
            //sign out
            frm_LogIn login = new frm_LogIn();
            login.Show();
            this.Hide();
        }
 
        internal void SetData(User userd)
        {

            lbl_userid.Text = userd.UserId.ToString();
            lbl_name.Text = userd.UserFirstName + " " + userd.UserLastName;

        }

    }
}
