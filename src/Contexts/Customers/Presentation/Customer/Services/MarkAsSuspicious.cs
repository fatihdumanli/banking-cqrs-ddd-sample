using System;
using ServiceStack;

namespace Customers.Presentation.Services

{
    [Route("/customer/{CustomerId}/suspicious", "PUT")]
    public class MarkAsSuspicious : IReturn<bool>
    {
        public Guid CustomerId { get; set; }    
    }
}