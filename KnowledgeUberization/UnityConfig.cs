using Common;
using KnowledgeUberization.Handlers;
using KnowledgeUberization.Providers;
using KnowledgeUberization.Sender;
using KnowledgeUberization.Services;
using MediatR;
using Microsoft.Extensions.Configuration;
using Unity;
using Unity.Injection;

namespace KnowledgeUberization
{
    public static class UnityConfig
    {
        public static IUnityContainer GetConfiguredContainer(IConfiguration configuration, bool diagnosticMode = false)
        {
            var container = diagnosticMode
                ? new UnityContainer().AddExtension(new Diagnostic())
                : new UnityContainer();

            DoRegistration(container, configuration);
            return container;
        }

        public static void DoRegistration(IUnityContainer container, IConfiguration configuration)
        {
            container.RegisterType<IExampleService, ExampleService>();
            container.RegisterType<IMqSender, MqSender>();
            container.RegisterType<IRequestHandler<AddExampleModelCommand, ExampleModel>,ExampleModelAddHandler>();
            container.RegisterType<IDbConnector, PostgresDbConnector>(
                new InjectionConstructor(
                    $"Host={configuration.GetSection("DATABASE_HOST").Value}; " + 
                    $"Port={configuration.GetSection("DATABASE_PORT").Value}; " + 
                    $"User ID={configuration.GetSection("DATABASE_USER").Value}; " +
                    $"Password={configuration.GetSection("DATABASE_PASSWORD").Value}; " +
                    $"Timeout = 60; " +
                    $"Command Timeout = 300; "));
            container.RegisterType<IUserProvider, UserProvider>(
                new InjectionConstructor(container.Resolve<IDbConnector>()));
        }
    }
}