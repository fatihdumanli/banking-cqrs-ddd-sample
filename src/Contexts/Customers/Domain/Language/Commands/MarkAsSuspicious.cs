using System;

namespace Customers.Domain.Commands
{
    public class MarkAsSuspicious : SeedWork.ICommand
    {
        public Guid CustomerId { get; private set; }

        public MarkAsSuspicious(Guid id)
        {
            this.CustomerId = id;            
        }
    }
}