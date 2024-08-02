using System.Configuration;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;
using gts_ApplicationStartup.Models;
using gts_ApplicationStartup.Services;
using Web.Models;
using Web.Services;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(Gendac.Gts.Web.Startup))]

namespace Gendac.Gts.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            // Register Unity container
            var container = new UnityContainer();
            RegisterTypes(container);

            // Set MVC Dependency Resolver
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            // Set Web API Dependency Resolver
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<DataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<ITeachersService, TeachersService>();
            container.RegisterType<IStudentsServices, StudentsServices>();
        }

        public void ConfigureAuth(IAppBuilder app)
        {
            // Add your authentication configuration here if needed
        }
    }
}



