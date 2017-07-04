using System.Diagnostics;
using System.Security.Authentication;

namespace Decorator.Decorators
{
    public sealed class AuthenticationLogDecorator : IAuthenticationService
    {
        private readonly IAuthenticationService decorable;

        public AuthenticationLogDecorator(IAuthenticationService decorable)
        {
            this.decorable = decorable;
        }

        public void Authenticate(string user, string password)
        {
            Trace.TraceInformation("Запрос аутентификации");

            try
            {
                // Делегирование вызова.
                decorable.Authenticate(user, password);

                Trace.TraceInformation("Пользователь аутентифицирован");
            }
            catch (AuthenticationException exception)
            {
                Trace.TraceError($"Ошибка аутентификации: {exception.Message}");
                throw;
            }
        }
    }
}
