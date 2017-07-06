using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public sealed class SyncMessagePublisher : MessagePublisher
    {
        public SyncMessagePublisher(IMessageQueue messageQueue) : base(messageQueue)
        {
        }

        public override void Publish(object message)
        {
            var messageContent = SerializeMessage(message);

            messageQueue.Enqueue(messageContent);
        }
    }
}