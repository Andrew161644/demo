using Microsoft.Extensions.Configuration;
using Reciever.Services;
using Unity;

namespace Reciever
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
            container.RegisterType<IMessageService, MessageService>();
        }
    }
}