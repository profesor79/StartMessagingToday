using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimpleQueue
{
    internal class ProducerOurWebApiEndpoint
    {
        public ProducerOurWebApiEndpoint()
        {
        }

        public void AddOrderToProcess(int orderNr, int customerId)
        {
            Queues.FirstSetOfMessages.Enqueue(new FirstMessagePayload
            {
                OrderNumber = orderNr,
                CustomerId = customerId,
            });
        }
    }
}