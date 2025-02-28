using RepositoryLayer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _userRegistrationRL;

        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public string registrationBL()
        {
            return _userRegistrationRL.registrationRL();   
        }

        public string checkRegistration(string username, string password)
        {
            if(username == "root" && password == "root")
            {
                return registrationBL();
            }
            return "Invalid Username and Password";
        }
    }
}
