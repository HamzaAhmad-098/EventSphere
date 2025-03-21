using System;
using ITECManagementSystem.DL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.BL
{
    public class LoginBL
    {
        LoginDL loginDL = new LoginDL();
        public User AuthenticateUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new Exception("Username and password are required.");
            User user = loginDL.GetUserByUsername(username);
            if (user == null)
            {
                throw new Exception("Username not found.");
            }
            if (user.PasswordHash != password)
            {
                throw new Exception("Incorrect password.");
            }
            return user;
        }
    }
}
