using System;

namespace SimpleQueue
{
    public class FirstMessagePayload
    {
        public int CustomerId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime TimeCreated { get; set; } = DateTime.UtcNow;
        // more stuff here as needed
    }
}