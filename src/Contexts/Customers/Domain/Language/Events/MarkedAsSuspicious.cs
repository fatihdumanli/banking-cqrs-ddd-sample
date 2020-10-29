using System;
using SeedWork;

namespace Customers.Domain.Events
{
    public class MarkedAsSuspicious : IEvent
    {
        public Guid CustomerId { get; private set; }

        public MarkedAsSuspicious(Guid id)
        {
            this.CustomerId = id;            
        }
    }
}