using System.Threading.Tasks;
using NServiceBus;

namespace Accounting.Presentation
{
    public class Service : ServiceStack.Service
    {
        private readonly NServiceBus.IMessageSession _nServiceBus;

        public Service(NServiceBus.IMessageSession bus)
        {
            _nServiceBus = bus;            
        }

        public Task Any(Services.Create request)
        {
            var command = new Domain.Commands.Create() { CustomerId = request.CustomerId, AccountUsageId = request.AccountUsageId, Currency = request.Currency };
            return _nServiceBus.Send("DomainEndpoint", command);
        }
    }
}