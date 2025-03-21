using System;
using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class EditionBL
    {
        EditionDL editionDL = new EditionDL();

        public List<Edition> GetEditions()
        {
            return editionDL.GetEditions();
        }

        public void AddEdition(Edition edition)
        {
            if (edition.Year <= 0)
                throw new Exception("Year must be a valid integer.");
            if (string.IsNullOrWhiteSpace(edition.Theme))
                throw new Exception("Theme cannot be empty.");
            editionDL.AddEdition(edition);
        }

        public void UpdateEdition(Edition edition)
        {
            if (edition.ItecId <= 0)
                throw new Exception("Invalid edition selection.");
            if (edition.Year <= 0)
                throw new Exception("Year must be a valid integer.");
            if (string.IsNullOrWhiteSpace(edition.Theme))
                throw new Exception("Theme cannot be empty.");
            editionDL.UpdateEdition(edition);
        }
        public void DeleteEdition(int itecId)
        {
            if (itecId <= 0)
                throw new Exception("Invalid edition selection.");
            editionDL.DeleteEdition(itecId);
        }
    }
}
