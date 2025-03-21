using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ITECManagementSystem.Models
{
    public class VenueAllocation
    {
        public int VenueAllocationId { get; set; }
        public int EventId { get; set; }
        public int VenueId { get; set; }
        public DateTime AssignedDate { get; set; }
        public string AssignedTime { get; set; }
        public string EventName { get; set; }
        public string VenueName { get; set; }
    }
}
