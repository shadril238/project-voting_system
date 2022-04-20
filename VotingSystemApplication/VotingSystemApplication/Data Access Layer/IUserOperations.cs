using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApplication.Data_Access_Layer
{
    internal interface IUserOperations
    {
        bool LoginUsers(string email, string password);


        bool RegCandidate(int usrid, string cparty);


        bool EnableVote();


        bool UpdateUserFirstName(int userid, string firstname);

        bool UpdateUserLastName(int userid, string lastname);

        bool UpdateUserFatherName(int userid, string fathername);


        bool UpdateUserMotherName(int userid, string mothername);


        bool UpdateUserBloodGroup(int userid, string bloodgroup);

        bool UpdateUserDOB(int userid, string dob);

        bool UpdateUserPhone(int userid, string phone);

        int ReadVote(string str);

        bool UpdateVote(string str, int vot);
        

    }
}
