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
    }
}
