﻿using System;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using Microsoft.Owin;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using Ninject;
using Articles.Data;

[assembly: OwinStartup(typeof(Articles.WebAPI.Startup))]

namespace Articles.WebAPI
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
            kernel.Bind<IArticlesData>().To<ArticlesData>().WithConstructorArgument("context", c => new ApplicationDbContext());
        }
        //</ninject>
    }
}
