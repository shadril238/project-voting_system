using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemApplication.Entities;

namespace VotingSystemApplication.Data_Access_Layer
{
    internal class AdminDataAccess:DataAccess, IAdminOperations
    {
        public static bool enableVote=false;
        public bool VerifyUser(int userid)
        {
            string verified = "true";
            string sql = "UPDATE Users SET isverified = '" + verified + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }
        public bool RemoveCandidate(int userid)
        {
            string verified = "false";
            string sql = "UPDATE Users SET candidateship = '" + verified + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }
        public bool DeleteFakeUsers(int userId)
        {
            string sql = "DELETE FROM Users WHERE userid = '" + userId + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }
    }
}
