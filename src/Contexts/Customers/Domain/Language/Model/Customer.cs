using System;

namespace Customers.Domain.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassportNo { get; set; }
        public string City { get; set; }
        public DateTime CreateDate { get; set; }
    }
}