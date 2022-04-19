using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApplication.Entities
{
    internal class Admin
    {
        private bool enableVote=false;
        public bool EnableVote
        {
            get { return enableVote; }      
            set { enableVote = value; }
        }
    }
}
