using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITECManagementSystem.Models
{
    namespace ITECManagementSystem.Models
    {
        public class Participant
        {
            public int ParticipantId { get; set; }
            public int ItecId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Contact { get; set; }
            public string Institute { get; set; }
            public int RoleId { get; set; }
        }
    }

}

