using System;

namespace Accounting.Domain.Aggregates
{
    public class Account : SeedWork.Aggregate
    {
        
        public void Create(Guid customerId, string currency, int accountUsageId)
        {
            ApplyEvent(new Domain.Events.Created() { Id = base.Id, AccountStatusId = 1, AccountUsageId = accountUsageId, Currency = currency, CustomerId = customerId });
        }
                
    }
}