using System;
using System.Collections.Concurrent;

namespace SimpleQueue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // we need to create a consumer class instance - or we will have no listener
            new ConsumerOurDatabaseAccess();
            new WarehouseOurBusinessLogicStuff();
            var p = new ProducerOurWebApiEndpoint();

            Console.WriteLine("Hey buddy provide order details - and don't play with me!");

            while (true)
            {
                Console.WriteLine("order nr");
                if (int.TryParse(Console.ReadLine(), out var orderNr))
                {
                    Console.WriteLine("customer id");
                    if (int.TryParse(Console.ReadLine(), out var customerId))
                    {
                        Console.WriteLine("pushing details to process");
                        p.AddOrderToProcess(orderNr, customerId);
                    }
                };

                Console.WriteLine("Done - ready for new order!");
            }
        }
    }
}