using System;
using System.Collections.Generic;
using System.Text;
using Nancy;
using Nancy.Authentication.Stateless;
using Nancy.Bootstrapper;
using Nancy.Bootstrappers.Autofac;
using Autofac;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Autofac.Extensions.DependencyInjection;

namespace NancyRealWorld
{
    public abstract class BootstrapperBase : AutofacNancyBootstrapper
    {
        public static ILifetimeScope BootstraperLifetimeScope;

        protected readonly IConfigurationRoot ConfigurationRoot;
        private readonly IServiceCollection _services;

        public BootstrapperBase(IServiceCollection services, IConfigurationRoot configurationRoot)
        {
            ConfigurationRoot = configurationRoot;
            _services = services;
        }

        protected override void ConfigureApplicationContainer(ILifetimeScope container)
        {         
            container.Update(builder => 
            {                
                builder.Populate(_services);
            });

            base.ConfigureApplicationContainer(container);

            BootstraperLifetimeScope = container;
        }
    }
}
