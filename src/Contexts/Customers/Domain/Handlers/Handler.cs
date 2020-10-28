using System.Threading.Tasks;
using Customers.Domain.Commands;
using NServiceBus;

namespace Customers.Domain.Handlers
{
    public class Handler : NServiceBus.IHandleMessages<Domain.Commands.Create>
    {
        public Task Handle(Create message, IMessageHandlerContext context)
        {
            var customer = new Domain.Aggregates.Customer();
            customer.Create(message.Name, message.Surname, message.PassportNo, message.City);
            return Task.CompletedTask;
        }
    }
}