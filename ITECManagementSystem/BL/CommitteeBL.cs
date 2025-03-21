using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class CommitteeBL
    {
        CommitteeDL committeeDL = new CommitteeDL();

        public List<Committee> GetCommittees()
        {
            return committeeDL.GetCommittees();
        }

        public List<ItechEdition> GetItechEditions()
        {
            return committeeDL.GetItechEditions();
        }

        public void AddCommittee(Committee committee)
        {
            if (string.IsNullOrWhiteSpace(committee.committee_name))
                throw new Exception("Committee name cannot be empty.");

            committeeDL.AddCommittee(committee);
        }

        public void UpdateCommittee(Committee committee)
        {
            if (committee.committee_id <= 0)
                throw new Exception("Invalid committee selection.");

            committeeDL.UpdateCommittee(committee);
        }

        public void DeleteCommittee(int committeeId)
        {
            if (committeeId <= 0)
                throw new Exception("Invalid committee selection.");

            committeeDL.DeleteCommittee(committeeId);
        }
    }
}
