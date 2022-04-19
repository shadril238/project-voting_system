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
 
        internal void SetData(User user)
        {
            lbl_userid.Text = user.UserId.ToString();
            lbl_name.Text = user.UserFirstName + " " + user.UserLastName;
            lbl_email.Text = user.UserEmail;
            lbl_phn.Text = user.UserPhone;
            lbl_fathername.Text = user.UserFatherName;
            lbl_mothername.Text = user.UserMotherName;
            lbl_dob.Text=user.UserDateOfBirth;
            lbl_bg.Text=user.UserBloodGroup;
            lbl_gender.Text = user.UserGender;
            lbl_location.Text = user.UserLocation;
            lbl_thana.Text = user.UserThana;
            lbl_district.Text = user.UserDistrict;
            lbl_division.Text = user.UserDivision;
            lbl_welcome.Text = "Welcome " + user.UserFirstName;
        }

        private void btn_updateData_Click(object sender, EventArgs e)
        {
            pnl_userdata.Visible = false;
            pnl_updatedata.Visible = true;
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            pnl_userdata.Visible = true;
            pnl_updatedata.Visible = false;
            
        }

        private void btn_vote_Click(object sender, EventArgs e)
        {
            UserDataAccess user=new UserDataAccess();
            if (user.EnableVote())
            {
                //MessageBox.Show("Vote Option Enabled!");
                frm_VotingDashboard vote=new frm_VotingDashboard();
                vote.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vote Option Not Enabled");
            }
        }
    }
}
