using System;
using ServiceStack;

namespace Customers.Presentation.Services
{
    [Route("/customer/{Id}/move/{City}", "PUT")]
    public class UpdateCity : IReturn<bool>
    {
        public Guid Id { get; set; }        
        public string City { get; set; }
    }
}