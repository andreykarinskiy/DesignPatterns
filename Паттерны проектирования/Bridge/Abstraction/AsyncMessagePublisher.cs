using System.Threading.Tasks;

using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public sealed class AsyncMessagePublisher : MessagePublisher
    {
        public AsyncMessagePublisher(IMessageQueue messageQueue) : base(messageQueue)
        {
        }

        public override void Publish(object message)
        {
            Task.Factory.StartNew(() =>
            {
                var messageContent = SerializeMessage(message);
                messageQueue.Enqueue(messageContent);
            });
        }
    }
}