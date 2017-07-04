using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public sealed class AuthenticationService : IAuthenticationService
    {
        public void Authenticate(string user, string password)
        {
            // Логика аутентификации...
        }
    }
}
