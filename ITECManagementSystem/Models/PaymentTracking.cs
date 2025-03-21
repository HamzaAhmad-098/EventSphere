using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITECManagementSystem.Models
{
    public class PaymentTracking
    {
        public int RegistrationId { get; set; }
        public string ParticipantName { get; set; }
        public string EventName { get; set; }
        public decimal FeeAmount { get; set; }
        public int PaymentStatusId { get; set; }
        public string PaymentStatus { get; set; }
    }
}
