using System;

namespace Customers.Domain.Commands
{
    public class MarkAsStarred : SeedWork.ICommand
    {
        public Guid CustomerId { get; private set; }

        public MarkAsStarred(Guid id)
        {
            this.CustomerId = id;            
        }
    }
}