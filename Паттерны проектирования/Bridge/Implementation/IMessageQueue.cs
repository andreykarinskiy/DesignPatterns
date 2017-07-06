namespace Bridge.Implementation
{
    public interface IMessageQueue
    {
        void Enqueue(byte[] messageContent);
    }
}