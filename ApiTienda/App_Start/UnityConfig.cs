using System.Data.Entity;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Repositorio.Model;
using Repositorio.Repositorio;
using Repositorio.ViewModel;
using Unity.WebApi;

namespace ApiTienda
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //Entity para todos los respositorios
            container.RegisterType<DbContext, Tienda15Entities>();

            //Producto
            container.RegisterType<
                IRepositorio<Producto, ProductoViewModel>,
                RepositorioEntity<Producto, ProductoViewModel>
                >();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}