using System;
using EnjoyDialogs.SCIM.Services;
using StructureMap.Configuration.DSL;

namespace EnjoyDialogs.SCIM.DependencyInjection
{
    [CLSCompliant(false)]
    public class ProjectRegistry : Registry
    {
        public ProjectRegistry()
        {
            For<IUserService>().Use<InMemoryUserService>();
            For<IGroupService>().Use<InMemoryGroupService>();
        }
    }
}