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

            if (reader.Read())
            {
                User user = new User();
                user.UserEmail = reader["useremail"].ToString();
                user.UserPassword = reader["userpassword"].ToString();
                if (email == user.UserEmail && password == user.UserPassword)
                {
                    Dispose();
                    return true;
                }
            }
            Dispose();
            return false;
        }

        //user registration
        public bool RegisterUsers()
        {

            return true;
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
    }
}
