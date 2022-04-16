using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApplication.Entities
{
    internal class User
    {
        private int id;
        private string name,email,userName,password;    

        //Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string UserName
        {
            get { return userName; }    
            set { userName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


    }
}
