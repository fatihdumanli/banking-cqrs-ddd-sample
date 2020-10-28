using ServiceStack;

namespace Customers.Presentation.Services
{
    [Route("/customer", "POST")]
    public class Add : IReturn<bool>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PassportNo { get; set; }
        public string City { get; set; }        
    }
}