using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using gts_ApplicationStartup.Services;
using Web.Services;
using System.Web.Optimization;
using System.Web.Routing;

namespace gts_ApplicationStartup
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new UnityContainer();
            container.RegisterType<ITeachersService, TeachersService>();
            container.RegisterType<IStudentsServices, StudentsServices>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}



