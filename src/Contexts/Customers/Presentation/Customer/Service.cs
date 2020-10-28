using System.Threading.Tasks;
using NServiceBus;

namespace Customers.Presentation
{
    public class Service : ServiceStack.Service
    {
        private readonly NServiceBus.IMessageSession _nServiceBus;

        public Service(NServiceBus.IMessageSession bus)
        {
            _nServiceBus = bus;            
        }


        public async Task<object> Any(Services.Add request)
        {
            var command = new Domain.Commands.Create() { Name = request.Name, Surname = request.Surname, City = request.City, PassportNo = request.PassportNo };
            _nServiceBus.Send("DomainEndpoint", command);
            return true;
        }

    }
}