using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.AuthenticationService
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            return (username == "admin" && password == "password");
        }

        public bool AuthorizeUser(string username, string role)
        {
            return (username == "admin" && role == "admin");
        }

        public BasicAuthenticationService()
        {
            
        }
    }
}
