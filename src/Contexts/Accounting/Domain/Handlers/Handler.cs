using Accounting.Domain.Commands;
using NServiceBus;
using SeedWork;
using System.Threading.Tasks;

namespace Accounting.Domain.Handlers
{
    public class Handler :
        NServiceBus.IHandleMessages<Accounting.Domain.Commands.Create>
    {
        public Task Handle(Create message, IMessageHandlerContext context)
        {
            var account = new Accounting.Domain.Aggregates.Account();
            account.Create(message.CustomerId, message.Currency, message.AccountUsageId);
            return account.PublishEvents(context);
        }
    }
}