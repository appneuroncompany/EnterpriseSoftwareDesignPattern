using DependencyInjectionWithNinject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWithNinject.Concrete
{
    public class ServicesA : ICarService
    {
        public void DoCarMaintenance()
        {
            Console.WriteLine("Araba bakımı A servisi tarafından gerçekleştirildi...");
        }
    }
}
