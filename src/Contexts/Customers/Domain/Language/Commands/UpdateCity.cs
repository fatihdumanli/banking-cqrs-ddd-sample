using System;

namespace Customers.Domain.Commands
{
    public class UpdateCity : SeedWork.ICommand
    {
        public Guid CustomerId { get; private set; }
        public string City { get; private set; }

        public UpdateCity(Guid id, string city)
        {
            this.CustomerId = id;
            this.City = city;            
        }
    }
}