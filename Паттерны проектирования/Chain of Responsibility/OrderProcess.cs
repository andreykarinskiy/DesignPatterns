using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public sealed class OrderProcess : IMessageHandler<OrderRequested>, IMessageHandler<OrderComplete>
    {
        private readonly IMessagePublisher publisher;

        public void Handle(OrderRequested message)
        {
            if (message.PaymentConfirmed)
            {
                publisher.Publish(new OrderComplete());
            }
        }

        public void Handle(OrderComplete message)
        {
        }
    }
}
