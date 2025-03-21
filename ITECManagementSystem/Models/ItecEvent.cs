using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITECManagementSystem.Models
{
    public class ItecEvent
    {
        public int EventId { get; set; }
        public int ItecId { get; set; }
        public string EventName { get; set; }
        public int EventCategoryId { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public int VenueId { get; set; }
        public int CommitteeId { get; set; }
    }
}


