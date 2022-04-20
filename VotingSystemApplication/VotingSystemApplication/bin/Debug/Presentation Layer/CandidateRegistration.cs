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
using VotingSystemApplication.Entities;

namespace VotingSystemApplication.Presentation_Layer
{
    public partial class txt_CandidateRegistration : Form
    {
        //private int currId = -1;
        public txt_CandidateRegistration()
        {
            //this.currId = id;
            //MessageBox.Show(id.ToString());
            InitializeComponent();
        }
        User user1=new User();
        public void UserID(string id)
        {
            user1.UserId = id;
        }
        private void chkBox_terms_Click(object sender, EventArgs e)
        {
            if (chkBox_terms.Checked)
            {
                btn_register.Enabled = true; //register button enabled
            }
            else
            {
                btn_register.Enabled = false;//register button disabled
            }
        }

        private void pictureBox_windowclosingReg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            UserDataAccess data= new UserDataAccess();
            if(data.RegCandidate(Convert.ToInt32(user1.UserId), txtBox_party.Text))
            {
                MessageBox.Show("Registration completed!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        
    }
}
