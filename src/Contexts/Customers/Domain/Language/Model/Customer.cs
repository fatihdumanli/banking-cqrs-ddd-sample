using System;

namespace Customers.Domain.Models
{
    //This class is used to persist entities. (Anemic model)
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassportNo { get; set; }
        public string City { get; set; }
        public DateTime CreateDate { get; set; }
        public int ClassificationId { get; set; }
        public int CustomerNo { get; set; }
    }
}