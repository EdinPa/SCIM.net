using System.Diagnostics;
using EnjoyDialogs.SCIM.DependencyInjection;
using StructureMap;

namespace EnjoyDialogs.SCIM
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
                {
                    x.Scan(scan =>
                        {
                            scan.TheCallingAssembly();
                            scan.WithDefaultConventions();
                        });
                    x.AddRegistry(new ProjectRegistry());
                });

            Debug.WriteLine(ObjectFactory.WhatDoIHave());
            return ObjectFactory.Container;
        }
    }
}