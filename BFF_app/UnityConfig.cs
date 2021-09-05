﻿﻿using Microsoft.Extensions.Configuration;
using Unity;

namespace BFF
{
    public static class UnityConfig
    {
        public static IUnityContainer GetConfiguredContainer(IConfiguration configuration, bool diagnosticMode = false)
        {
            var container = diagnosticMode
                ? new UnityContainer().AddExtension(new Diagnostic())
                : new UnityContainer();

            DoCustomRegistration(container, configuration);
            return container;
        }

        public static void DoCustomRegistration(IUnityContainer container, IConfiguration configuration)
        {
            
        }
    }
}