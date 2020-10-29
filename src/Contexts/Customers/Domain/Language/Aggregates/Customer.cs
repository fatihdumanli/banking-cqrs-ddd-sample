using System;

namespace Customers.Domain.Aggregates
{
    public class Customer : SeedWork.Aggregate
    {

        public Customer()
        {
            
        }
        public Customer(Guid id)
        {
            Id = id;                     
        }
        public void Create(string name, string surname, string passportNo, string city)
        {
            ApplyEvent(new Events.Created() {
                Id = base.Id,
                Name = name,
                Surname = surname,
                City = city,
                PassportNo = passportNo
            });
        }

        public void MarkAsStarred()
        {
            ApplyEvent(new Events.MarkedAsStarred(this.Id));
        }
    }
}