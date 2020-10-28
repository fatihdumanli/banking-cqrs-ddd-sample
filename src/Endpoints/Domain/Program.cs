using System;
using NServiceBus;

namespace Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            var endpointConfiguration = new EndpointConfiguration("DomainEndpoint");
            endpointConfiguration.EnableInstallers();
            endpointConfiguration.UseTransport<RabbitMQTransport>().ConnectionString("amqp://localhost").UseDirectRoutingTopology();
            Endpoint.Start(endpointConfiguration).ConfigureAwait(false);
            Console.WriteLine("Domain endpoint is started");
            Console.Read();
        }
    }
}
