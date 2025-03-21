using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class SponsorBL
    {
        SponsorDL sponsorDL = new SponsorDL();
        public List<Sponsor> GetSponsors()
        {
            return sponsorDL.GetSponsors();
        }
        public bool AddSponsor(Sponsor sponsor)
        {
            if (sponsor == null)
                throw new Exception("Sponsor cannot be null.");
            if (string.IsNullOrWhiteSpace(sponsor.SponsorName))
                throw new Exception("Sponsor name is required.");
            if (sponsorDL.InsertSponsor(sponsor))
            {
                return true;
            }
            return false;
        }
        public bool UpdateSponsor(Sponsor sponsor)
        {
            if (sponsor == null || sponsor.SponsorId <= 0)
                throw new Exception("Invalid sponsor selection.");
            if (sponsorDL.UpdateSponsor(sponsor))
            {
                return true;
            }
            return false;
        }
        public bool DeleteSponsor(int sponsorId)
        {
            if (sponsorId <= 0)
                throw new Exception("Invalid sponsor selection.");
            if (sponsorDL.DeleteSponsor(sponsorId))
            {
                return true;
            }
            return false;
        }
    }
}
