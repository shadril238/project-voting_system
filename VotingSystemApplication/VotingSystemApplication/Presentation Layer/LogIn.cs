using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VotingSystemApplication.Data_Access_Layer;

namespace VotingSystemApplication.Presentation_Layer
{
    
    public partial class frm_LogIn : Form
    {

        public frm_LogIn()
        {
            InitializeComponent();
        }

        private void pictureBox_windowclosing_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            if(txt_email.Text ==@"Email Address")
            {
                txt_email.Text = "";
            }

        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = @"Email Address";
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == @"Password")
            {
                txt_password.Text = "";
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = @"Password";
            }
        }

        private void Combo_role_Enter(object sender, EventArgs e)
        {
            if (Combo_role.Text==@"Please Select")
            {
                Combo_role.Text = "";
            }
        }

        private void Combo_role_Leave(object sender, EventArgs e)
        {
            if (Combo_role.Text == "")
            {
                Combo_role.Text = @"Please Select";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(Combo_role.Text == @"Please Select" || Combo_role.Text == "")
            {
                MessageBox.Show("Log In role must be selected!");
            }
            else if(txt_email.Text=="" || txt_email.Text== @"Email Address")
            {
                MessageBox.Show("Email should not be blank!");
            }
            else if(txt_password.Text=="" || txt_password.Text == @"Password")
            {
                MessageBox.Show("Password should not be blank!");
            }
            else
            {
                //All the backend mechanism for Log In button
                UserDataAccess user=new UserDataAccess();
                if (user.LoginUsers(txt_email.Text, txt_password.Text))
                {
                    MessageBox.Show("YOO MADAFAKa!");
                }
                else
                {
                    MessageBox.Show("FUCK YOU MADAFAKa!");
                }


            }
        }
    }
}
