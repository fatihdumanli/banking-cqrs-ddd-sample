using Accounting.Domain.Events;
using Microsoft.EntityFrameworkCore;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Write
{
    public class Handler :
        NServiceBus.IHandleMessages<Domain.Events.Created>
    {
        private DbContextOptionsBuilder builder = new DbContextOptionsBuilder()
            .UseSqlServer("Server=localhost,1433;Initial Catalog=AccountService;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=True;Connection Timeout=5;");
        public Task Handle(Created message, IMessageHandlerContext context)
        {
            var dbContext = new AccountingDbContext(builder.Options);
            var accountModel = new Domain.Model.Account()
            {
                Id = message.Id,
                Currency = message.Currency,
                CreateDate = DateTime.UtcNow,
                CustomerId = message.CustomerId
            };         

            dbContext.Accounts.Add(accountModel);
            dbContext.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
