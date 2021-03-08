using DependencyInjectionWithNinject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWithNinject.Concrete
{
    class ServicesB : ICarService
    {
        public void DoCarMaintenance()
        {
            Console.WriteLine("Araba bakımı B servisi tarafından gerçekleştirildi...");
        }
    }
}
