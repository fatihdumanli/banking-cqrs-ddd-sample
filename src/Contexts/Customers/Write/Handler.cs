using Customers.Domain.Enumerations;
using Customers.Domain.Events;
using Microsoft.EntityFrameworkCore;
using NServiceBus;
using SeedWork;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Customers.Write
{
    public class Handler :
          NServiceBus.IHandleMessages<Customers.Domain.Events.Created>,
          NServiceBus.IHandleMessages<Customers.Domain.Events.MarkedAsStarred>
    {
        DbContextOptionsBuilder<CustomerDbContext> builder =
                    new DbContextOptionsBuilder<CustomerDbContext>().UseSqlServer("Server=localhost,1433;Initial Catalog=CustomerService;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=True;Connection Timeout=5;");

        public Task Handle(Created message, IMessageHandlerContext context)
        {

            var dbContext = new CustomerDbContext(builder.Options);

            var customer = new Customers.Domain.Models.Customer()
            {
                Id = message.Id,
                Name = message.Name,
                Surname = message.Surname,
                PassportNo = message.PassportNo,
                City = message.City,
                CreateDate = DateTime.UtcNow
            };

            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();

            return Task.CompletedTask;
        }

        public Task Handle(MarkedAsStarred message, IMessageHandlerContext context)
        {
            var dbContext = new CustomerDbContext(builder.Options);
            var customer = dbContext.Customers.Where(c => c.Id == message.CustomerId).SingleOrDefault();
            customer.ClassificationId = Classification.Starred.Id;
            dbContext.SaveChanges();
            return Task.CompletedTask;
        }
    }
}