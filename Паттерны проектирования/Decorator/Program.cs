using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Decorator.Decorators;

namespace Decorator
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            IAuthenticationService service = new AuthenticationService();
            IAuthenticationService loggingDecorator = new AuthenticationLogDecorator(service);

            loggingDecorator.Authenticate("Василий", "12345");
        }
    }
}
