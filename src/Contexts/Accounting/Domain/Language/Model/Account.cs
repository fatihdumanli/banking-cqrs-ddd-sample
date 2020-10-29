using System;

namespace Accounting.Domain.Model
{
    public class Account
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string AccountNo { get; set; }
        public string Currency { get; set; }
        public int AccountStatusId { get; set; }
        //Single usage, common usage
        public int AccountUsageId { get; set; }
        public DateTime CreateDate { get; set; }
    }
}