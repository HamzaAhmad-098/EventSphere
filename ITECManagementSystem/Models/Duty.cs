using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITECManagementSystem.Models
{
    public class Duty
    {
        public int DutyId { get; set; }
        public int CommitteeId { get; set; }
        public string AssignedTo { get; set; }
        public string TaskDescription { get; set; }
        public DateTime Deadline { get; set; }
        public int StatusId { get; set; }
    }
}

