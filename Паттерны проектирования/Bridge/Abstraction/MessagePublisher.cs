using System;

using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public abstract class MessagePublisher
    {
        protected readonly IMessageQueue messageQueue;

        protected MessagePublisher(IMessageQueue messageQueue)
        {
            this.messageQueue = messageQueue;
        }

        public abstract void Publish(object message);

        protected byte[] SerializeMessage(object message)
        {
            throw new NotImplementedException();
        }
    }
}