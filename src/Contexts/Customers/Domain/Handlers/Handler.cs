using System.Threading.Tasks;
using Customers.Domain.Commands;
using NServiceBus;

namespace Customers.Domain.Handlers
{
    public class Handler : 
        NServiceBus.IHandleMessages<Domain.Commands.Create>,
        NServiceBus.IHandleMessages<Domain.Commands.MarkAsStarred>,
        NServiceBus.IHandleMessages<Domain.Commands.UpdateCity>,
        NServiceBus.IHandleMessages<Domain.Commands.MarkAsSuspicious>
    {
        public Task Handle(Create message, IMessageHandlerContext context)
        {
            var customer = new Domain.Aggregates.Customer();
            customer.Create(message.Name, message.Surname, message.PassportNo, message.City);
            //customer.Create causes a event.
            //Can be accessed via customer.UncommitedEvents.
            //Domain endpoint is responsible for publishing these event(s).

            return customer.PublishEvents(context);
        }

        public Task Handle(MarkAsStarred message, IMessageHandlerContext context)
        {
            var customer = new Domain.Aggregates.Customer(message.CustomerId);
            customer.MarkAsStarred();
            return customer.PublishEvents(context);            
        }

        public Task Handle(UpdateCity message, IMessageHandlerContext context)
        {
            var customer = new Domain.Aggregates.Customer(message.CustomerId);
            customer.Move(message.City);
            return customer.PublishEvents(context);
        }

        public Task Handle(MarkAsSuspicious message, IMessageHandlerContext context)
        {
            var customer = new Domain.Aggregates.Customer(message.CustomerId);
            customer.MarkAsSuspicious();
            return customer.PublishEvents(context);
        }
    }
}