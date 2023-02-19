using System;
using System.Threading.Tasks;

namespace SimpleQueue
{
    public class WarehouseOurBusinessLogicStuff
    {
        public WarehouseOurBusinessLogicStuff()
        {
            Task.Run(ListenForNewOrders);
        }

        private void ListenForNewOrders()
        {
            while (true)
            {
                if (Queues.OrderDetailsQueue.TryDequeue(out var order))
                {
                    Console.WriteLine($"WAREHOUSE: order n: {order.OrderNumber}, customer id: {order.CustomerId}, time of entry: {order.TimeOfEntry}");
                    Console.WriteLine($"WAREHOUSE: order details: {string.Join(", ", order.ProductAmountList)}");
                }
            }
        }
    }
}