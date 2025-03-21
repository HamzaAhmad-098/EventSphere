using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITECManagementSystem.Models
{
    public class Edition
    {
        public int ItecId { get; set; }
        public int Year { get; set; }
        public string Theme { get; set; }
        public string Description { get; set; }

        public Edition() { }

        public Edition(int itecId, int year, string theme, string description)
        {
            ItecId = itecId;
            Year = year;
            Theme = theme;
            Description = description;
        }
    }
}


