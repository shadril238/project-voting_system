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
    internal class UserDataAccess:DataAccess
    {
        public bool LoginUsers(string email, string password)
        {
            string sql = "SELECT * FROM Users_Auth";
            SqlDataReader reader = this.GetData(sql);
            
            if (reader.Read())
            {
                if(email==reader["useremail"] && password == reader["userpassword"])
                {
                    return true;
                }
            }
            return false;
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
