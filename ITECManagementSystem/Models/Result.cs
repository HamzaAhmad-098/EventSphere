using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITECManagementSystem.Models
{
    public class ResultRecord
    {
        public int ResultId { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public int? ParticipantId { get; set; }
        public string ParticipantName { get; set; }
        public int? TeamId { get; set; }
        public string TeamName { get; set; }
        public int Position { get; set; }
        public decimal Score { get; set; }
        public string Remarks { get; set; }
    }
}




