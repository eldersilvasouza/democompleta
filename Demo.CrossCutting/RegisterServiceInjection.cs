

using Demo.App;
using Demo.App.Interfaces;
using Demo.Data.Interfaces.Services;
using Demo.Data.Services;
using Demo.Domain.Interfaces.Repositories;
using Demo.Domain.Repositories;
using Demo.Domain.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web.Mvc;

namespace Demo.CrossCutting
{
    public static class RegisterServiceInjection
    {


        public static void Container()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            container.Register<Demo.Data.Context.DemoContext>(Lifestyle.Scoped);


            ///Repository
            container.Register(typeof(RepositoryBase<>));
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);


            ///ServiceBase
            container.Register(typeof(ServiceBase<>));
            container.Register<IClienteService, ClienteService>(Lifestyle.Scoped);


            ///AppService
            container.Register(typeof(AppServiceBase<>));
            container.Register<IClienteAppService, ClienteAppService>(Lifestyle.Scoped);


            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));





        }
        



    }
}
