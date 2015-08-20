using System;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using BulsAndCows.Data;
using Microsoft.Owin;
using Ninject;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;

[assembly: OwinStartup(typeof(BulsAndCows.WebApi.Startup))]

namespace BulsAndCows.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //<ninject>
            app.UseNinjectMiddleware(CreateKernel).UseNinjectWebApi(GlobalConfiguration.Configuration);
        }

        private static StandardKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            RegisterMappings(kernel);
            return kernel;
        }

        private static void RegisterMappings(StandardKernel kernel)
        {
            kernel.Bind<IBulsAndCowsData>().To<BulsAndCowsData>().WithConstructorArgument("context", c => new ApplicationDbContext());
        }
        //</ninject>
    }
}
