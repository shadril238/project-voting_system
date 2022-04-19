using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemApplication.Entities;
using VotingSystemApplication.Presentation_Layer;

namespace VotingSystemApplication.Data_Access_Layer
{
    internal class UserDataAccess : DataAccess
    {
        //user login
        public bool LoginUsers(string email, string password)
        {
            string sql = "SELECT * FROM UsersAuth";
            SqlDataReader reader = this.GetData(sql);
            
            while (reader.Read())
            {
                User user = new User();
                user.UserEmail = reader["useremail"].ToString();
                user.UserPassword = reader["userpassword"].ToString();
                if (email == user.UserEmail && password == user.UserPassword)
                {
                    return true;
                }
            }
            return false;
        }

        //user registration
        public bool InsertUserData(User user)
        {
            string sql = "INSERT INTO Users(userfirstname, userlastname, useremail, userphone,usergender, userbloodgroup, userfathername, usermothername,userlocation, userthana, userdistrict, userdivision, userdob) VALUES ('"+user.UserFirstName+"', '"+user.UserLastName+"', '"+user.UserEmail+"' , '"+user.UserPhone+"', '"+user.UserGender+"', '"+user.UserBloodGroup + "', '"+user.UserFatherName+"' , '"+user.UserMotherName+"', '"+user.UserLocation+"', '"+user.UserThana+"', '"+user.UserDistrict+"', '"+user.UserDivision+ "','" + user.UserDateOfBirth + "')";
            int flag = this.ExecuteQuery(sql);
            return flag > 0;
        }
        // user password store
        public bool InsertUserPassWord(User user) 
        {
            string sql = "INSERT INTO UsersAuth(useremail, userpassword) VALUES ('"+user.UserEmail+"', '"+user.UserPassword+"')";
            int flag = this.ExecuteQuery(sql);
            return flag > 0;
        }
        //user data on dashboard
        public User UserData(string email)
        {
            User user=null;
            string sql = "SELECT * FROM Users WHERE useremail='"+email+"'" ;
            SqlDataReader reader = this.GetData(sql);
           
            while (reader.Read())
            {
                user = new User();
                user.UserId = reader["userid"].ToString();
                user.UserFirstName = reader["userfirstname"].ToString();
                user.UserLastName = reader["userlastname"].ToString();
                user.UserEmail = reader["useremail"].ToString();
                user.UserPhone = reader["userphone"].ToString();
                user.UserGender = reader["usergender"].ToString();
                user.UserBloodGroup = reader["userbloodgroup"].ToString();
                user.UserFatherName = reader["userfathername"].ToString();
                user.UserMotherName = reader["usermothername"].ToString();
                user.UserLocation = reader["userlocation"].ToString() ;
                user.UserThana = reader["userthana"].ToString();
                user.UserDistrict = reader["userdistrict"].ToString();
                user.UserDivision = reader["userdivision"].ToString();
                user.UserDateOfBirth = reader["userdob"].ToString();
            }
            return user;
        }
        //All Users Data
        public List<User> GetUsers()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = this.GetData(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                ///.Id
                ///
                users.Add(user);
            }
            return users;
        }
        //Vote option enable
        public bool EnableVote()
        {
            return AdminDataAccess.enableVote;
        }

        //update first name
        public bool UpdateUserFirstName(int userid, string firstname) {
            string sql = "UPDATE Users SET userfirstname = '"+firstname+"' WHERE userid = '"+userid+"'";
            int result  =  this.ExecuteQuery(sql);
            return result > 0;
        }
        //update last Name
        public bool UpdateUserLastName(int userid, string lastname)
        {
            string sql = "UPDATE Users SET userlastname = '" + lastname + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }

        //update father name
        public bool UpdateUserFatherName(int userid, string fathername)
        {
            string sql = "UPDATE Users SET userfathername = '" + fathername + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }

        // update mother name
        public bool UpdateUserMotherName(int userid, string  mothername)
        {
            string sql = "UPDATE Users SET usermothername = '" + mothername + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }

        // update blood group
        public bool UpdateUserBloodGroup(int userid, string bloodgroup)
        {
            string sql = "UPDATE Users SET userbloodgroup = '" + bloodgroup + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }

        // update dob
        public bool UpdateUserDOB(int userid, string dob)
        {
            string sql = "UPDATE Users SET userdob = '" + dob + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }

        // update phone
        public bool UpdateUserPhone(int userid, string phone)
        {
            string sql = "UPDATE Users SET userphone = '" + phone + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }
    }
}
