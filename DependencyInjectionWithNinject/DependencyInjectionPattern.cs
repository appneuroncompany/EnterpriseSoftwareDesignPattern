using DependencyInjectionWithNinject.Abstract;
using Ninject;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DependencyInjectionWithNinject
{

    /// <summary>
    /// uygulama içerisinde nesne yaratma sürecinin sizden alınıp, bunun bir çatıya yani Framework’e devredilmesi işlemine Inversion of Control denmektedir. 
    /// Dependency Injection deseninin ise işlevsel olarak, nesneler arasında bağımlılıkları soyutlama görevini yürüttüğünü biliyoruz. 
    /// İşte Ninject – IoC Library’si, DI desenini basitçe uygulayabilmemizi ve kullanmamızı sağlayan hazır bir Container(kapsayıcı) olarak inşa edilmiştir.
    /// </summary>
    public class DependencyInjectionPattern
    {
        public static void TestDependencyInjection()
        {
            using (var kernel = new StandardKernel())
            {
                ICarService carService;
                kernel.Load(Assembly.GetExecutingAssembly());
                carService = kernel.Get<ICarService>();
                carService.DoCarMaintenance();
            }
        }
    }
}
