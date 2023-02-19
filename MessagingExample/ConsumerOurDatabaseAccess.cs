using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleQueue
{
    internal class ConsumerOurDatabaseAccess
    {
        public ConsumerOurDatabaseAccess()
        {
            // we need to run our listener in a new thread as we don't want to block the app
            Task.Run(ListenForNewOrders);
        }

        public void ListenForNewOrders()
        {
            var r = new Random();

            while (true)
            {
                if (Queues.FirstSetOfMessages.TryDequeue(out var order))
                {
                    Console.WriteLine($"DISPATCHER: order n: {order.OrderNumber}, customer id: {order.CustomerId}, time of entry: {order.TimeCreated}");
                    Console.WriteLine("DISPATCHER: Getting order details from storage");
                    Thread.Sleep(r.Next(3500, 5000));

                    var items = r.Next(2, 12);
                    var msg = new SecondMessagePayload
                    {
                        CustomerId = order.CustomerId,
                        OrderDetails = order,
                        OrderNumber = order.OrderNumber
                    };

                    for (int i = 0; i < items; i++)
                    {
                        msg.ProductAmountList.Add(Tuple.Create(r.Next(1, 9999), r.NextDouble() * 367));
                    }

                    Console.WriteLine("DISPATCHER: Processed order details from storage");
                    Queues.OrderDetailsQueue.Enqueue(msg);
                }
                else
                {
                    Thread.Sleep(2000);
                }
            }
        }
    }
}