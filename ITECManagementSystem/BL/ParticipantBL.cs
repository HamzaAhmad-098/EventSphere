using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;
using ITECManagementSystem.Models.ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class ParticipantBL
    {
        ParticipantDL participantDL = new ParticipantDL();
        public bool RegisterParticipant(Participant participant, int eventId, decimal feeAmount)
        {
            if (string.IsNullOrWhiteSpace(participant.Name) || string.IsNullOrWhiteSpace(participant.Email))
                throw new Exception("Name and email are required.");
            if(participantDL.RegisterParticipant(participant, eventId, feeAmount))
            {
                return true;
            }
            return false;
        }
        public List<KeyValuePair<int, string>> GetEditions()
        {
            return participantDL.GetEditions();
        }
        public List<KeyValuePair<int, string>> GetEvents()
        {
            return participantDL.GetEvents();
        }

        public List<KeyValuePair<int, string>> GetRoles()
        {
            return participantDL.GetRoles();
        }
    }
}
