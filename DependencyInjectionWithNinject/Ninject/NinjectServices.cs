using System;
using DependencyInjectionWithNinject.Abstract;
using DependencyInjectionWithNinject.Concrete;
using Ninject.Modules;

namespace DependencyInjectionWithNinject.Ninject
{
    public class NinjectServices : NinjectModule
    {
        public override void Load()
        {
            Bind<ICarService>().To<ServicesB>();
           

        }
    }
}
