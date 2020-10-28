using Customers.Domain.Events;
using NServiceBus;
using SeedWork;
using System.Threading.Tasks;

namespace Customers.Write
{
    public class Handler
        : NServiceBus.IHandleMessages<Customers.Domain.Events.Created>
    {

        private readonly UnitOfWork _unitOfWork;

        public Handler(UnitOfWork uow)
        {
            _unitOfWork = uow;
        }

        public Task Handle(Created message, IMessageHandlerContext context)
        {
            var eventReceived = message;
            return Task.CompletedTask;
        }
    }
}