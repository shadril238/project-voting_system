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
using VotingSystemApplication.Entities;

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
                //All the backend mechanism for Register button
                UserDataAccess user1=new UserDataAccess();
                
                if (Combo_role.Text=="USER"  )
                {
                    bool val=true;
                    try
                    {
                        val = user1.LoginUsers(txt_email.Text, txt_password.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Welcome!");
                    }
                    finally
                    {
                        user1.Dispose();
                    }
                    if (val)
                    {
                        //user.Dispose();
                        
                        //MessageBox.Show("Dashboard Pending!");
                        frm_UserDashboard dashboard = new frm_UserDashboard();
                        
                        //insert user data
                        User user = new User();
                        UserDataAccess user2 = new UserDataAccess();
                        user = user2.UserData(txt_email.Text);
                        //user.Dispose();

                        dashboard.SetData(user);
                        dashboard.Show();


                        this.Hide();
                        
                        user2.Dispose();
                        

                    }


                }
                else if (Combo_role.Text=="ADMIN") ///admin database
                {
                    frm_AdminDashboard dashboard=new frm_AdminDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Log In failed!");
                }
            }
        }

        // Redirect to Register form
        private void lbl_3_Click(object sender, EventArgs e)
        {
            frm_UserRegistration frm = new frm_UserRegistration();
            frm.Show();
            this.Hide();
        }
    }
}
