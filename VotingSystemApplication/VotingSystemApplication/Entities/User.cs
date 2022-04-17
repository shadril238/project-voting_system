using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApplication.Entities
{
    internal class User
    {
        private int userId;
        private string userName, userEmail, userPassword, userPhone, ;

        //Properties
        public int UserId
        {
            get { return this.UserId; }
            set { this.userId = value; }
        }
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        public string UserEmail
        {
            get { return this.userEmail; }
            set { this.userEmail = value; }
        }
        
        public string UserPassword
        {
            get { return this.userPassword; }
            set { this.userPassword = value; }
        }


    }
}
