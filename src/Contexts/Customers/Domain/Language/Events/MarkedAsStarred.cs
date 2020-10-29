using System;
using SeedWork;

namespace Customers.Domain.Events
{
    public class MarkedAsStarred : IEvent
    {
        public Guid CustomerId { get; private set; }

        public MarkedAsStarred(Guid id)
        {
            this.CustomerId = id;            
        }
    }
}