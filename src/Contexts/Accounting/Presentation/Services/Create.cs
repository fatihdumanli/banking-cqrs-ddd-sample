using System;
using ServiceStack;

namespace Accounting.Presentation.Services
{
    [Route("/account", "POST")]
    public class Create : IReturn<bool>
    {
        public Guid CustomerId { get; set; }
        public string Currency { get; set; }
        public int AccountUsageId { get; set; }       
    }
}