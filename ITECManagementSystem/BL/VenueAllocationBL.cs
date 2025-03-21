using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class VenueAllocationBL
    {
        VenueAllocationDL allocationDL = new VenueAllocationDL();
        public List<VenueAllocation> GetVenueAllocations()
        {
            return allocationDL.GetVenueAllocations();
        }
        public void AddVenueAllocation(VenueAllocation allocation)
        {
            if (allocation.EventId <= 0)
                throw new Exception("Invalid event selected.");
            if (allocation.VenueId <= 0)
                throw new Exception("Invalid venue selected.");
            if (allocation.AssignedDate == DateTime.MinValue)
                throw new Exception("Invalid assigned date.");
            if (string.IsNullOrWhiteSpace(allocation.AssignedTime))
                throw new Exception("Assigned time cannot be empty.");

            allocationDL.AddVenueAllocation(allocation);
        }

        public void UpdateVenueAllocation(VenueAllocation allocation)
        {
            if (allocation.VenueAllocationId <= 0)
                throw new Exception("Invalid venue allocation selection.");
            if (allocation.EventId <= 0)
                throw new Exception("Invalid event selected.");
            if (allocation.VenueId <= 0)
                throw new Exception("Invalid venue selected.");
            if (allocation.AssignedDate == DateTime.MinValue)
                throw new Exception("Invalid assigned date.");
            if (string.IsNullOrWhiteSpace(allocation.AssignedTime))
                throw new Exception("Assigned time cannot be empty.");

            allocationDL.UpdateVenueAllocation(allocation);
        }

        public void DeleteVenueAllocation(int venueAllocationId)
        {
            if (venueAllocationId <= 0)
                throw new Exception("Invalid venue allocation selection.");
            allocationDL.DeleteVenueAllocation(venueAllocationId);
        }

        public List<ItecEvent> GetEvents()
        {
            return allocationDL.GetEvents();
        }

        public List<Venue> GetVenues()
        {
            return allocationDL.GetVenues();
        }
    }
}
