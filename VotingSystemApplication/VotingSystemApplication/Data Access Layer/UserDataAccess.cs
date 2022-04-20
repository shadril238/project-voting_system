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
    internal class UserDataAccess : DataAccess, IUserOperations
    {
        public static int totalVote=0, candidate1=0, candidate2=0;
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
        public bool InsertUserData(Candidate user)
        {
            
            string sql = "INSERT INTO Users(userfirstname, userlastname, useremail, userphone,usergender, userbloodgroup, userfathername, usermothername,userlocation, userthana, userdistrict, userdivision, userdob, isverified, candidateship, candidateparty , candidateroll, candidatevotecount) VALUES ('"+user.UserFirstName+"', '"+user.UserLastName+"', '"+user.UserEmail+"' , '"+user.UserPhone+"', '"+user.UserGender+"', '"+user.UserBloodGroup + "', '"+user.UserFatherName+"' , '"+user.UserMotherName+"', '"+user.UserLocation+"', '"+user.UserThana+"', '"+user.UserDistrict+"', '"+user.UserDivision+ "','" + user.UserDateOfBirth + "', '"+user.isVerified+"', '"+user.isCandidate+"', '"+user.politicalParty+ "', '"+user.candidateRoll+"', '"+user.totalvotes+"')";
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
            
            string sql = "SELECT * FROM Users WHERE useremail='"+email+"'" ;
            SqlDataReader reader = this.GetData(sql);
            User user = new User();
            while (reader.Read())
            {
                   
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
                user.isVerified = reader["isverified"].ToString();
                user.isCandidate = reader["candidateship"].ToString();
                
            }
            return user;
        }

        //verified Users Data
        public List<User> VerifiedUsers()
        {
            string verified = "true";
            string sql = "SELECT * FROM Users WHERE isverified = '" + verified + "'";
            SqlDataReader reader = this.GetData(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.UserId = reader["userid"].ToString();
                user.UserFirstName = reader["userfirstname"].ToString();
                user.UserLastName = reader["userlastname"].ToString();
                user.UserEmail = reader["useremail"].ToString();
                user.UserPhone = reader["userphone"].ToString();
                user.UserGender = reader["usergender"].ToString();
                user.UserBloodGroup = reader["userbloodgroup"].ToString();
                user.UserFatherName = reader["userfathername"].ToString();
                user.UserMotherName = reader["usermothername"].ToString();
                user.UserLocation = reader["userlocation"].ToString();
                user.UserThana = reader["userthana"].ToString();
                user.UserDistrict = reader["userdistrict"].ToString();
                user.UserDivision = reader["userdivision"].ToString();
                user.UserDateOfBirth = reader["userdob"].ToString();
                user.isCandidate = reader["candidateship"].ToString();
                user.isVerified = reader["isverified"].ToString();
                users.Add(user);
            }
            return users;
        }
        //unverified Users Data
        public List<User> UnverifiedUsers()
        {
            string verified = "false";
            string sql = "SELECT * FROM Users WHERE isverified = '"+verified+"'";
            SqlDataReader reader = this.GetData(sql);
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.UserId = reader["userid"].ToString();
                user.UserFirstName = reader["userfirstname"].ToString();
                user.UserLastName = reader["userlastname"].ToString();
                user.UserEmail = reader["useremail"].ToString();
                user.UserPhone = reader["userphone"].ToString();
                user.UserGender = reader["usergender"].ToString();
                user.UserBloodGroup = reader["userbloodgroup"].ToString();
                user.UserFatherName = reader["userfathername"].ToString();
                user.UserMotherName = reader["usermothername"].ToString();
                user.UserLocation = reader["userlocation"].ToString();
                user.UserThana = reader["userthana"].ToString();
                user.UserDistrict = reader["userdistrict"].ToString();
                user.UserDivision = reader["userdivision"].ToString();
                user.UserDateOfBirth = reader["userdob"].ToString();
                user.isCandidate = reader["candidateship"].ToString();
                user.isVerified = reader["isverified"].ToString();
                users.Add(user);
            }
            return users;
        }
        //Candidates Data - CDA
        public List<Candidate> CandidatesList()
        {
            string verified = "true";
            string sql = "SELECT * FROM Users WHERE isverified = '" + verified + "' AND candidateship= '" + verified + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Candidate> candidates = new List<Candidate>();
            while (reader.Read())
            {
                Candidate candidate = new Candidate();
                candidate.UserId = reader["userid"].ToString();
                candidate.UserFirstName = reader["userfirstname"].ToString();
                candidate.UserLastName = reader["userlastname"].ToString();
                candidate.UserEmail = reader["useremail"].ToString();
                candidate.UserPhone = reader["userphone"].ToString();
                candidate.UserGender = reader["usergender"].ToString();
                candidate.UserBloodGroup = reader["userbloodgroup"].ToString();
                candidate.UserFatherName = reader["userfathername"].ToString();
                candidate.UserMotherName = reader["usermothername"].ToString();
                candidate.UserLocation = reader["userlocation"].ToString();
                candidate.UserThana = reader["userthana"].ToString();
                candidate.UserDistrict = reader["userdistrict"].ToString();
                candidate.UserDivision = reader["userdivision"].ToString();
                candidate.UserDateOfBirth = reader["userdob"].ToString();
                candidate.isCandidate = reader["candidateship"].ToString();
                candidate.isVerified = reader["isverified"].ToString();
                candidate.politicalParty = reader["candidateparty"].ToString();
                candidate.candidateRoll= reader["candidateroll"].ToString() ;
                candidate.totalvotes = (int)reader["candidatevotecount"];

                candidates.Add(candidate);
            }
            return candidates;
        }
        //reg candidate
        public bool RegCandidate(int usrid, string cparty)
        {
            string verified = "true";
            string sql = "UPDATE Users SET  candidateship='"+verified+"', candidateparty='"+cparty+"'  WHERE userid='"+usrid+"'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }
        //Vote option enable
        public bool EnableVote()
        {
            return AdminDataAccess.enableVote;
        }

        //update first name
        public bool UpdateUserFirstName(int userid, string firstname) {
            string verified = "false";
            string sql = "UPDATE Users SET userfirstname = '"+firstname+ "', isverified = '" + verified + "' WHERE userid = '" + userid+"'";
            int result  =  this.ExecuteQuery(sql);
            return result > 0;
        }
        //update last Name
        public bool UpdateUserLastName(int userid, string lastname)
        {
            string verified = "false";
            string sql = "UPDATE Users SET userlastname = '" + lastname + "', isverified = '" + verified + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }

        //update father name
        public bool UpdateUserFatherName(int userid, string fathername)
        {
            string verified = "false";
            string sql = "UPDATE Users SET userfathername = '" + fathername + "', isverified = '" + verified + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }

        // update mother name
        public bool UpdateUserMotherName(int userid, string  mothername)
        {
            string verified = "false";
            string sql = "UPDATE Users SET usermothername = '" + mothername + "', isverified = '" + verified + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }

        // update blood group
        public bool UpdateUserBloodGroup(int userid, string bloodgroup)
        {
            string verified = "false";
            string sql = "UPDATE Users SET userbloodgroup = '" + bloodgroup + "', isverified = '" + verified + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }

        // update dob
        public bool UpdateUserDOB(int userid, string dob)
        {
            string verified = "false";
            string sql = "UPDATE Users SET userdob = '" + dob + "', isverified = '" + verified + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }

        // update phone
        public bool UpdateUserPhone(int userid, string phone)
        {
            string verified = "false";
            string sql = "UPDATE Users SET userphone = '" + phone + "', isverified = '" + verified + "' WHERE userid = '" + userid + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }
        // vote update
        public int ReadVote(string str)
        {
            
            string sql = "SELECT candidatevotecount FROM Users WHERE candidateroll = '" + str + "'";
            SqlDataReader reader = this.GetData(sql);
            Candidate user = new Candidate();
            while (reader.Read())
            {

                return ++user.totalvotes;

            }
            
            return -1;
        }
        public bool UpdateVote(string str, int vot)
        {
            
            string sql = "UPDATE Users SET candidatevotecount = '" + vot + "' WHERE candidateroll = '" + str + "'";
            int result = this.ExecuteQuery(sql);
            return result > 0;
        }


    }
}
