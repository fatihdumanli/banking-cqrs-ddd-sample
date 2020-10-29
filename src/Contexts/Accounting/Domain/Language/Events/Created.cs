using System;

namespace Accounting.Domain.Events
{
    public class Created : SeedWork.IEvent
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string AccountNo { get; set; }
        public string Currency { get; set; }
        public int AccountStatusId { get; set; }
        public int AccountUsageId { get; set; }                
    }
}