namespace Customers.Domain.Aggregates
{
    public class Customer : SeedWork.Aggregate
    {
        public void Create(string name, string surname, string passportNo, string city)
        {
            ApplyEvent(new Events.Created() {
                Name = name,
                Surname = surname,
                City = city,
                PassportNo = passportNo
            });
        }
    }
}