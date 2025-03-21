using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class EventBL
    {
        EventDL eventDL = new EventDL();

        public List<ItecEvent> GetEvents()
        {
            return eventDL.GetEvents();
        }

        public bool AddEvent(ItecEvent evt)
        {
            if (evt == null)
                throw new Exception("Event cannot be null.");
            if (string.IsNullOrWhiteSpace(evt.EventName))
                throw new Exception("Event name is required.");
            if (evt.EventDate == DateTime.MinValue)
                throw new Exception("Valid event date is required.");
            if (eventDL.InsertEvent(evt))
            {
                return true;
            }
            return false;
        }

        public bool UpdateEvent(ItecEvent evt)
        {
            if (evt == null || evt.EventId <= 0)
                throw new Exception("Invalid event selection.");
            if (eventDL.UpdateEvent(evt))
            {
                return true;
            }
            return false;
        }

        public bool DeleteEvent(int eventId)
        {
            if (eventId <= 0)
                throw new Exception("Invalid event selection.");
            if (eventDL.DeleteEvent(eventId))
            {
                return true;
            }
            return false;
        }
        public List<ItechEdition> GetEditions()
        {
            return eventDL.GetEditions();
        }

        public List<EventCategory> GetEventCategories()
        {
            return eventDL.GetEventCategories();
        }

        public List<Committee> GetCommittees()
        {
            return eventDL.GetCommittees();
        }

        public List<Venue> GetVenues()
        {
            return eventDL.GetVenues();
        }
    }
}
