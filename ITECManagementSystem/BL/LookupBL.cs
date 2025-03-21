using System.Collections.Generic;
using ITECManagementSystem.DL;

namespace ITECManagementSystem.BL
{
    public class LookupBL
    {
        LookupDL lookupDL = new LookupDL();
        public List<KeyValuePair<int, string>> GetLookupValues(string category)
        {
            return lookupDL.GetLookupValues(category);
        }
    }
}
