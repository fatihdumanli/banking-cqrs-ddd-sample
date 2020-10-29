using System;

namespace Customers.Domain.Events
{
    public class MovedToNewCity : SeedWork.IEvent
    {
        public Guid CustomerId { get; private set; }
        public string City { get; private set; }

        public MovedToNewCity(Guid id, string city)
        {
            this.CustomerId = id;
            this.City = city;            
        }
    }
}