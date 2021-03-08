using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPoolingDesignPattern
{
    public class PoolingObject
    {
        public int MyId { get; set; }

        public PoolingObject()
        {
            Console.WriteLine("ObjectCreated. Id id ${0}... and Waiting for call", MyId);
            Random random = new Random();
            MyId = random.Next(1, 150);
        }

        public void GetMessage()
        {
            Console.WriteLine("Hı I am pooled object. My id is ${0} :) ", MyId);
        }
    }
}
