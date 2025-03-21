using System.Collections.Generic;
using ITECManagementSystem.DL;

namespace ITECManagementSystem.BL
{
    public class EntitySelectionBL
    {
        EntitySelectionDL selectionDL = new EntitySelectionDL();

        public List<KeyValuePair<int, string>> GetEntitiesByType(string entityType)
        {
            return selectionDL.GetEntities(entityType);
        }
    }
}
