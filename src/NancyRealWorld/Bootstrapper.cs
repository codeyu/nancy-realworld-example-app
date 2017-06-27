using System;
using System.Collections.Generic;
using System.Text;
using Nancy;
using Nancy.Authentication.Stateless;
using Nancy.Bootstrapper;
using Nancy.Bootstrappers.Autofac;
using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using NancyRealWorld.Infrastructure;

namespace NancyRealWorld
{
    public class Bootstrapper  : BootstrapperBase
    {
        public Bootstrapper(IServiceCollection services, IConfigurationRoot configurationRoot)
                :base(services, configurationRoot)                
        {
        }

        protected override void ConfigureApplicationContainer(ILifetimeScope container)
        { 
            container.Update(builder => 
            {
                builder.RegisterType<IdentityProvider>().As<IIdentityProvider>();
                builder.RegisterInstance(ConfigurationRoot.RegisterSetting<AuthSettings>(nameof(AuthSettings))).SingleInstance();
            });

            base.ConfigureApplicationContainer(container);
        }

        protected override void ApplicationStartup(ILifetimeScope container, IPipelines pipelines)
        {
            var identityProvider = BootstraperLifetimeScope.Resolve<IIdentityProvider>();
            var statelessAuthConfig = new StatelessAuthenticationConfiguration(identityProvider.GetUserIdentity);

            StatelessAuthentication.Enable(pipelines, statelessAuthConfig);   

            base.ApplicationStartup(container, pipelines);
        }
    }
}
