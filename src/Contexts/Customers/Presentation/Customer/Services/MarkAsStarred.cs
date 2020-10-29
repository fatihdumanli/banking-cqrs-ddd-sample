using System;
using ServiceStack;

namespace Customers.Presentation.Services

{
    [Route("/customer/{CustomerId}/star", "PUT")]
    public class MarkAsStarred : IReturn<bool>
    {
        public Guid CustomerId { get; set; }    
    }
}