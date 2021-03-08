using FluentInterfaceDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluentInterfaceDesignPattern.Concrete
{
    public class Tank : ITank
    {
        public ITank Defence()
        {
            Console.WriteLine("Tank is defence position");
                return this;
        }

        public ITank Fire()
        {
            Console.WriteLine("Tank is Firing...");
            return this;
        }

        public ITank GetItem()
        {
            Console.WriteLine("Tank is getting smt item");
            return this;
        }
    }
}
