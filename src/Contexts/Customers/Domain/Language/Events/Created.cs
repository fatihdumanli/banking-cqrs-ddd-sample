using System;

namespace Customers.Domain.Events
{
    public class Created : SeedWork.IEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string PassportNo { get; set; }
    }
}