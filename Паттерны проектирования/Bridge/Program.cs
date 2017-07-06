using Bridge.Abstraction;
using Bridge.Implementation;

namespace Bridge
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            IMessageQueue queue = new RabbitQueue();
            MessagePublisher publisher = new SyncMessagePublisher(queue);
            publisher.Publish("Preved!");
        }
    }
}