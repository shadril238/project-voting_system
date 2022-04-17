using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystemApplication.Data_Access_Layer
{
    public partial class frm_UserRegistration : Form
    {
        public frm_UserRegistration()
        {
            InitializeComponent();
        }

        private void txtBox_name1_Enter(object sender, EventArgs e)
        {
            if (txtBox_name1.Text == @"First Name")
            {
                txtBox_name1.Text = "";
            }
        }

        private void txtBox_name1_Leave(object sender, EventArgs e)
        {
            if (txtBox_name1.Text == "")
            {
                txtBox_name1.Text = @"First Name";
            }
        }

        private void txtBox_name2_Enter(object sender, EventArgs e)
        {
            if (txtBox_name2.Text == @"Last Name")
            {
                txtBox_name2.Text = "";
            }
        }

        private void txtBox_name2_Leave(object sender, EventArgs e)
        {
            if (txtBox_name2.Text == "" )
            {
                txtBox_name2.Text =@"Last Name";
            }

        }

        private void txtBox_email_Enter(object sender, EventArgs e)
        {
            if(txtBox_email.Text == @"Email Address")
            {
                txtBox_email.Text = "";
            }
        }

        private void txtBox_email_Leave(object sender, EventArgs e)
        {
            if (txtBox_email.Text == "")
            {
                txtBox_email.Text = @"Email Address";
            }
        }

        private void txtBox_phoneno_Enter(object sender, EventArgs e)
        {
            if(txtBox_phoneno.Text == @".Phone No")
            {
                txtBox_phoneno.Text = "";
            }
        }

        private void txtBox_phoneno_Leave(object sender, EventArgs e)
        {
            if (txtBox_phoneno.Text == "")
            {
                txtBox_phoneno.Text = @".Phone No";
            }
        }


        //form closing event
        private void pictureBox_windowclosingReg_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void txtBox_password_Enter(object sender, EventArgs e)
        {
            if(txtBox_password.Text == @"Password")
            {
                txtBox_password.Text = "";
            }
        }

        private void txtBox_password_Leave(object sender, EventArgs e)
        {
            if (txtBox_password.Text == "")
            {
                txtBox_password.Text = @"Password";
            }
        }

        private void txtBox_cpassword_Enter(object sender, EventArgs e)
        {
            if (txtBox_cpassword.Text == @"Password")
            {
                txtBox_cpassword.Text = "";
            }
        }

        private void txtBox_cpassword_Leave(object sender, EventArgs e)
        {
            if (txtBox_cpassword.Text == "")
            {
                txtBox_cpassword.Text = @"Password";
            }
        }

        private void comboBox_gender_Enter(object sender, EventArgs e)
        {
            if(comboBox_gender.Text == @"Select Gender")
            {
                comboBox_gender.Text = "";
            }
        }

        private void comboBox_gender_Leave(object sender, EventArgs e)
        {
            if(comboBox_gender.Text == "")
            {
                comboBox_gender.Text = @"Select Gender";
            }
        }

        private void txtBox_father_Enter(object sender, EventArgs e)
        {
            if(txtBox_father.Text ==@"Father's Name")
            {
                txtBox_father.Text = "";
            }
        }

        private void txtBox_father_Leave(object sender, EventArgs e)
        {
            if( txtBox_father.Text == "")
            {
                txtBox_father.Text = @"Father's Name";
            }
        }

        private void txtBox_mother_Enter(object sender, EventArgs e)
        {
            if(txtBox_mother.Text == @"Mother's Name")
            {
                txtBox_mother.Text = "";
            }
        }

        private void txtBox_mother_Leave(object sender, EventArgs e)
        {
            if (txtBox_mother.Text == "")
            {
                txtBox_mother.Text = @"Mother's Name";
            }
        }

        private void txtBox_location_Enter(object sender, EventArgs e)
        {
            if(txtBox_location.Text == @"Location")
            {
                txtBox_location.Text = "";
            }
        }

        private void txtBox_location_Leave(object sender, EventArgs e)
        {
            if(txtBox_location.Text == "")
            {
                txtBox_location.Text = @"Location";
            }
        }

        private void txtBox_thana_Enter(object sender, EventArgs e)
        {
            if(txtBox_thana.Text == @"Thana")
            {
                txtBox_thana.Text = "";
            }
        }

        private void txtBox_thana_Leave(object sender, EventArgs e)
        {
            if (txtBox_thana.Text == "")
            {
                txtBox_thana.Text = @"Thana";
            }

        }

        private void txtBox_district_Enter(object sender, EventArgs e)
        {
            if(txtBox_district.Text == @"District")
            {
                txtBox_district.Text = "";
            }
        }

        private void txtBox_district_Leave(object sender, EventArgs e)
        {
            if (txtBox_district.Text == "")
            {
                txtBox_district.Text = @"District";
            }

        }

        private void comboBox_division_Enter(object sender, EventArgs e)
        {
            if(comboBox_division.Text == @"Select Division")
            {
                comboBox_division.Text = "";
            }
        }

        private void comboBox_division_Leave(object sender, EventArgs e)
        {
            if (comboBox_division.Text == "")
            {
                comboBox_division.Text = @"Select Division";
            }
        }

        private void comboBox_bloodgroup_Enter(object sender, EventArgs e)
        {
            if(comboBox_bloodgroup.Text == @"Select Blood Group")
            {
                comboBox_bloodgroup.Text = "";
            }

        }

        private void comboBox_bloodgroup_Leave(object sender, EventArgs e)
        {
            if (comboBox_bloodgroup.Text == "")
            {
                comboBox_bloodgroup.Text = @"Select Blood Group";
            }
        }
    }
}
