using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class VenueBL
    {
        VenueDL venueDL = new VenueDL();
        public List<Venue> GetVenues()
        {
            return venueDL.GetVenues();
        }
        public void AddVenue(Venue venue)
        {
            if (string.IsNullOrWhiteSpace(venue.VenueName))
                throw new Exception("Venue name cannot be empty.");
            if (venue.Capacity <= 0)
                throw new Exception("Capacity must be a positive number.");
            if (string.IsNullOrWhiteSpace(venue.Location))
                throw new Exception("Location cannot be empty.");
            venueDL.AddVenue(venue);
        }
        public void UpdateVenue(Venue venue)
        {
            if (venue.VenueId <= 0)
                throw new Exception("Invalid venue selection.");
            if (string.IsNullOrWhiteSpace(venue.VenueName))
                throw new Exception("Venue name cannot be empty.");
            if (venue.Capacity <= 0)
                throw new Exception("Capacity must be a positive number.");
            if (string.IsNullOrWhiteSpace(venue.Location))
                throw new Exception("Location cannot be empty.");
            venueDL.UpdateVenue(venue);
        }
        public void DeleteVenue(int venueId)
        {
            if (venueId <= 0)
                throw new Exception("Invalid venue selection.");
            venueDL.DeleteVenue(venueId);
        }
        public List<Venue> SearchVenues(string searchText)
        {
            return venueDL.SearchVenues(searchText);
        }
    }
}
