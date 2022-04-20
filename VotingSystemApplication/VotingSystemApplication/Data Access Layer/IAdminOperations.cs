using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApplication.Data_Access_Layer
{
    internal interface IAdminOperations
    {
        bool VerifyUser(int userid);

        bool RemoveCandidate(int userid);

        bool DeleteFakeUsers(int userId);
        
    }
}
