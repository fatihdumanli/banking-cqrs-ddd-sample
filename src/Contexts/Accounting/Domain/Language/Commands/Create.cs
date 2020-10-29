using System;

namespace Accounting.Domain.Commands
{
    public class Create : SeedWork.ICommand
    {
        public Guid CustomerId { get; set; }
        public string Currency { get; set; }
        public int AccountUsageId { get; set; }                
    }
}