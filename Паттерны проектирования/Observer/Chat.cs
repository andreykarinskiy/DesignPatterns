using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public sealed class Chat
    {
        private readonly ISubject<UserMessage> incomingStream = new ReplaySubject<UserMessage>();

        public IObservable<UserMessage> IncomingMessages
        {
            get
            {
                return incomingStream;
            }
        }

        public void SendMessage(UserMessage message)
        {
            // ...
        }
    }
}
