using NServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SeedWork
{
    public static class EventPublisherExtension
    {
        public static async Task PublishEvents(this Aggregate aggregate, IMessageHandlerContext ctx)
        {
            var events = aggregate.UncomittedEvents;

            foreach (var e in events)
            {
                var task = ctx.Publish(e);
            }
        }

    }
}
