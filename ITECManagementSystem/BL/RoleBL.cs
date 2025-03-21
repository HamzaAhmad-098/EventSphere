using System.Collections.Generic;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class RoleBL
    {
        RoleDL roleDL = new RoleDL();
        public List<Role> GetRoles()
        {
            return roleDL.GetRoles();
        }
    }
}
