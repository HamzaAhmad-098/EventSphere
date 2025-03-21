using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITECManagementSystem.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public int CommitteeId { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
    }
}

