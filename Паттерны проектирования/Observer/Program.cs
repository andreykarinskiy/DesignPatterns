using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var chat = new Chat();

            chat.IncomingMessages.Subscribe(msg =>
            {
                Console.WriteLine($"Ответ: {msg}");
            });

            chat.SendMessage(new UserMessage("Preved, Medved!"));
        }
    }
}
