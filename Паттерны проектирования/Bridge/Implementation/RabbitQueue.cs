using System;

namespace Bridge.Implementation
{
    public sealed class RabbitQueue : IMessageQueue
    {
        public void Enqueue(byte[] messageContent)
        {
            throw new NotImplementedException();
        }
    }
}