using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dependencies;
using System.Web.Mvc;
using EnjoyDialogs.SCIM.DependencyResolution;

namespace EnjoyDialogs.SCIM
{

    public static class IoCConfig
    {
        public static void RegisterStructuremap(HttpConfiguration config)
        {
            var container = IoC.Initialize();
            var resolver = new SmDependencyResolver(container);

            DependencyResolver.SetResolver(resolver);
            config.DependencyResolver = resolver;
        }
    }



    public class SmDependencyResolver : ScopeContainer, System.Web.Mvc.IDependencyResolver, System.Web.Http.Dependencies.IDependencyResolver
    {
        public SmDependencyResolver(StructureMap.IContainer container) 
            : base (container)
        {
        }
        
        public IDependencyScope BeginScope()
        {
            var child = container.GetNestedContainer();
            return new ScopeContainer(child);
        }
    }

    public class ScopeContainer : IDependencyScope
    {
        protected readonly StructureMap.IContainer container;

        public ScopeContainer(StructureMap.IContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.container = container; 

        }

        public void Dispose()
        {
            container.Dispose();
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == null) return null;
            try
            {
                return serviceType.IsAbstract || serviceType.IsInterface
                         ? container.TryGetInstance(serviceType)
                         : container.GetInstance(serviceType);
            }
            catch
            {

                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return container.GetAllInstances(serviceType).Cast<object>();
        }
    }
}