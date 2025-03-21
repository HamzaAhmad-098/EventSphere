using System;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class UserBL
    {
        UserDL userDL = new UserDL();
        public int GetOrCreateRoleId(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                throw new Exception("Role name cannot be empty.");
            return userDL.GetOrCreateRoleId(roleName);
        }
        public bool RegisterUser(User user)
        {
            if (user == null)
                throw new Exception("User cannot be null.");
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.PasswordHash))
                throw new Exception("Username, Email, and Password are required.");
            if (userDL.CreateUser(user))
            {
                return true;
            }
            return false;
        }
    }
}
