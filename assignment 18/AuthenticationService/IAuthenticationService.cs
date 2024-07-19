using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.AuthenticationService
{
    internal interface IAuthenticationService
    {
        //create method for authentication
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }
}
