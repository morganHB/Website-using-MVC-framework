using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using gts_ApplicationStartup.Services;
using Web.Services;

namespace gts_ApplicationStartup
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            container.RegisterType<IStudentsServices, StudentsServices>();
            container.RegisterType<ITeachersService, TeachersService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            return container;
        }
    }
}
