using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleQueue
{
    internal class LegacyCodeExample
    {
        private LegacyProducer _p;

        public LegacyCodeExample()
        {
            // I hope that the other class is injected by DI here
            _p = new LegacyProducer();
            // some di here as well, maybe CTX or context access
        }

        public void NewOrder(int customerId, int orederId)
        {
            _p.NewOrder(new FirstMessagePayload { CustomerId = customerId, OrderNumber = orederId });
        }
    }

    internal class LegacyProducer
    {
        private LegacyDispatcher _d;

        public LegacyProducer()
        {
            _d = new LegacyDispatcher();
        }

        internal void NewOrder(FirstMessagePayload firstMessagePayload)
        {
        }
    }

    internal class LegacyDispatcher
    {
        public LegacyDispatcher()
        {
        }
    }
}