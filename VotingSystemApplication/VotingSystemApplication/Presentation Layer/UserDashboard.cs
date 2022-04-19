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

        User user = new User();
        internal void SetData(User user)
        {
            this.user = user;
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
            //*********** Data On Update Data Panel ******************//
            txt_updatefather.Text = user.UserFatherName;
            txt_updatemother.Text = user.UserMotherName;
            txt_updatefirstname.Text = user.UserFirstName;
            txt_updatelastname.Text = user.UserLastName;
            txt_updatebg.Text = user.UserBloodGroup;
            txt_updatephn.Text = user.UserPhone;   
            dateTimePicker_updatedob.Text = user.UserDateOfBirth;
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

        private void btn_firstname_Click(object sender, EventArgs e)
        {
            UserDataAccess dataAccess=new UserDataAccess();
            if(dataAccess.UpdateUserFirstName(Convert.ToInt32(lbl_userid.Text), txt_updatefirstname.Text) && txt_updatefirstname.Text != "" && user.UserFirstName!= txt_updatefirstname.Text)
            {
                MessageBox.Show("First Name Updated!");
                user.UserFirstName = txt_updatefirstname.Text;
                lbl_name.Text = user.UserFirstName + " " + user.UserLastName;
                lbl_welcome.Text = "Welcome " + user.UserFirstName;

            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btn_lastname_Click(object sender, EventArgs e)
        {
            UserDataAccess dataAccess = new UserDataAccess();
            if (dataAccess.UpdateUserLastName(Convert.ToInt32(lbl_userid.Text), txt_updatelastname.Text) && txt_updatelastname.Text != "" && user.UserLastName != txt_updatelastname.Text)
            {
                MessageBox.Show("Last Name Updated!");
                user.UserLastName = txt_updatelastname.Text;
                lbl_name.Text = user.UserFirstName + " " + user.UserLastName;
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btn_bg_Click(object sender, EventArgs e)
        {
            UserDataAccess dataAccess = new UserDataAccess();
            if (dataAccess.UpdateUserBloodGroup(Convert.ToInt32(lbl_userid.Text), txt_updatebg.Text) && txt_updatebg.Text != "" && user.UserBloodGroup != txt_updatebg.Text)
            {
                MessageBox.Show("Blood Group Updated!");
                user.UserBloodGroup = txt_updatebg.Text;
                lbl_bg.Text = user.UserBloodGroup;


            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btn_phnno_Click(object sender, EventArgs e)
        {

            UserDataAccess dataAccess = new UserDataAccess();
            if (dataAccess.UpdateUserPhone(Convert.ToInt32(lbl_userid.Text), txt_updatephn.Text) && txt_updatephn.Text != "" && user.UserPhone != txt_updatephn.Text)
            {
                MessageBox.Show("Phone No Updated!");
                user.UserPhone = txt_updatephn.Text;
                lbl_phn.Text = user.UserPhone;
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btn_fathername_Click(object sender, EventArgs e)
        {
            UserDataAccess dataAccess = new UserDataAccess();
            if (dataAccess.UpdateUserFatherName(Convert.ToInt32(lbl_userid.Text), txt_updatefather.Text) && txt_updatefather.Text != "" && user.UserFatherName != txt_updatefather.Text)
            {
                MessageBox.Show("Father's Name Updated!");
                user.UserFatherName = txt_updatefather.Text;
                lbl_fathername.Text = user.UserFatherName;
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btn_mothername_Click(object sender, EventArgs e)
        {
            UserDataAccess dataAccess = new UserDataAccess();
            if (dataAccess.UpdateUserMotherName(Convert.ToInt32(lbl_userid.Text), txt_updatemother.Text) && txt_updatemother.Text != "" && user.UserMotherName != txt_updatemother.Text)
            {
                MessageBox.Show("Mother's Name Updated!");
                user.UserMotherName = txt_updatemother.Text;
                lbl_mothername.Text = user.UserMotherName;
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btn_dob_Click(object sender, EventArgs e)
        {
            UserDataAccess dataAccess = new UserDataAccess();
            if (dataAccess.UpdateUserDOB(Convert.ToInt32(lbl_userid.Text), dateTimePicker_updatedob.Text) && dateTimePicker_updatedob.Text != "" && user.UserDateOfBirth != dateTimePicker_updatedob.Text)
            {
                MessageBox.Show("Date Of Birth Updated!");
                user.UserDateOfBirth = dateTimePicker_updatedob.Text;
                dateTimePicker_updatedob.Text = user.UserDateOfBirth;
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        
    }
}
