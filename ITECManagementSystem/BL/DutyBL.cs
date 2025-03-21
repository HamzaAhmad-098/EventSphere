using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class DutyBL
    {
        DutyDL dutyDL = new DutyDL();

        public List<Duty> GetDuties()
        {
            return dutyDL.GetDuties();
        }

        public bool AddDuty(Duty duty)
        {
            if (duty == null)
                throw new Exception("Duty cannot be null.");
            if (duty.CommitteeId <= 0)
                throw new Exception("A valid committee must be selected.");
            if (string.IsNullOrWhiteSpace(duty.AssignedTo))
                throw new Exception("AssignedTo field is required.");
            if (string.IsNullOrWhiteSpace(duty.TaskDescription))
                throw new Exception("Task description is required.");
            if (duty.Deadline == DateTime.MinValue)
                throw new Exception("A valid deadline is required.");
            if (dutyDL.InsertDuty(duty))
            {
                return true;
            }
            return false;
         
        }

        public bool UpdateDuty(Duty duty)
        {
            if (duty == null || duty.DutyId <= 0)
                throw new Exception("Invalid duty selection.");
            if (dutyDL.UpdateDuty(duty))
            {
                return true;
            }
            return false;
        }

        public bool DeleteDuty(int dutyId)
        {
            if (dutyId <= 0)
                throw new Exception("Invalid duty selection.");
            if (dutyDL.DeleteDuty(dutyId))
            {
                return true;
            }
            return false;
        }
    }
}
