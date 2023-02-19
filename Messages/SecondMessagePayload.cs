using System;
using System.Collections.Generic;

namespace SimpleQueue
{
    public class SecondMessagePayload
    {
        public FirstMessagePayload OrderDetails { get; set; }
        public List<Tuple<int, double>> ProductAmountList { get; set; } = new List<Tuple<int, double>>();
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime TimeOfEntry { get; set; } = DateTime.UtcNow;
    }
}