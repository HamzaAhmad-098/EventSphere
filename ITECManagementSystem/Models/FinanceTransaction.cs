using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITECManagementSystem.Models
{
    public class FinanceTransaction
    {
        public int TransactionId { get; set; }
        public int ItecId { get; set; }
        public int EventId { get; set; }
        public int TypeId { get; set; }
        public decimal Amount { get; set; }
        public string FromEntityType { get; set; } 
        public int FromEntityId { get; set; }
        public string ToEntityType { get; set; } 
        public int ToEntityId { get; set; }
        public string Description { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}


