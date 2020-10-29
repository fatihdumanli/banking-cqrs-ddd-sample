using Customers.Domain.Events;
using NServiceBus;
using SeedWork;
using System.Threading.Tasks;

namespace Customers.Write
{
    public class Handler
        : NServiceBus.IHandleMessages<Customers.Domain.Events.Created>
    {
        public Task Handle(Created message, IMessageHandlerContext context)
        {
            var eventReceived = message;
            return Task.CompletedTask;
        }
    }
}