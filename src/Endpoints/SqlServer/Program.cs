using System;
using NServiceBus;
using SeedWork;
using StructureMap;

namespace SqlServer
{
    class Program
    {
        private static IContainer _container;


        static void Main(string[] args)
        {    
            var endpointConfiguration = new EndpointConfiguration("SqlServerEndpoint");
            var registry = new Registry();
            registry.For<UnitOfWork>().Use(new UnitOfWork());

            
            endpointConfiguration.UseContainer(new StructureMapServiceProviderFactory(registry));
            endpointConfiguration.EnableInstallers();
            endpointConfiguration.UseTransport<RabbitMQTransport>().ConnectionString("amqp://localhost").UseDirectRoutingTopology();
            Endpoint.Start(endpointConfiguration).ConfigureAwait(false);
            Console.WriteLine("Domain endpoint is started");
            Console.Read();
        }
    }
}
