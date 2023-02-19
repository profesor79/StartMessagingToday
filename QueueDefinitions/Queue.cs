using System.Collections.Concurrent;

namespace SimpleQueue
{
    internal static class Queues
    {
        public static ConcurrentQueue<FirstMessagePayload>
            FirstSetOfMessages
        { get; } = new ConcurrentQueue<FirstMessagePayload>();

        public static ConcurrentQueue<SecondMessagePayload>
            OrderDetailsQueue
        { get; } = new ConcurrentQueue<SecondMessagePayload>();
    }
}