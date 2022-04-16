using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemApplication.Entities;

namespace VotingSystemApplication.Data_Access_Layer
{
    internal class UserDataAccess:DataAccess
    {
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
