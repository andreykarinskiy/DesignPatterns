using System;

namespace Bridge.Implementation
{
    public sealed class MsmqQueue : IMessageQueue
    {
        public void Enqueue(byte[] messageContent)
        {
            throw new NotImplementedException();
        }
    }
}