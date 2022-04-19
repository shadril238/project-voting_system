using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApplication.Entities
{
    internal class Candidate:User //Candidate is also a user
    {
        public string politicalParty { get; set; }
        public string candidateRoll { get; set; }
    }
}
