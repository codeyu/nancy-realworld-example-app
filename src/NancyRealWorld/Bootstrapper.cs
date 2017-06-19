using System;
using System.Collections.Generic;
using System.Text;
using Nancy;
using Nancy.TinyIoc;
namespace NancyRealWorld
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        private readonly IAppConfiguration _appConfig;
        public Bootstrapper()
        {
        }

        public Bootstrapper(IAppConfiguration appConfig)
        {
            this._appConfig = appConfig;
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register<IAppConfiguration>(_appConfig);
        }
    }
}
