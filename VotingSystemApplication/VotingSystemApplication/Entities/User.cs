using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApplication.Entities
{
    internal class User
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }

        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserPassword { get; set; }    


        public string UserDateOfBirth { get; set; }

        public string UserGender { get; set; }
        public string UserFatherName { get;  set; }
        public string UserMotherName { get;  set; }
        public string UserLocation { get; set; }
        public string UserThana { get; set; }
        public string UserDistrict { get; set; }
        public string UserDivision { get; set; }
        public string UserBloodGroup { get; set; }
    }
}
