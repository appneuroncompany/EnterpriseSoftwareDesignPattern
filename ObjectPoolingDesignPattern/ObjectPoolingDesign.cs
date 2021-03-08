using System;

namespace ObjectPoolingDesignPattern
{
    /// <summary>
    /// Object pooling tekrarlı kullanılan nesnelerin üretim ve imha süreçlerinde meydana gelen maliyetlerin minimize edilmesi için üretilen nesnenin bir kaynakta/alanda/havuzda tutulması üzerine geliştirilmiş tasarım desenidir.
    /// </summary>
    public class ObjectPoolingDesign
    {
        public static void TestObjectPoolingCustomMethod()
        {
            CustomObjectPool<PoolingObject> customObjectPool = new CustomObjectPool<PoolingObject>(() => new PoolingObject());
            var obj1 = customObjectPool.Get();
            Console.WriteLine(obj1.MyId);
            var obj2 = customObjectPool.Get();
            Console.WriteLine(obj2.MyId);

            Console.WriteLine("//////////////////////////////////////////////");

            customObjectPool.Return(obj1);
            customObjectPool.Return(obj2);

            var obj3 = customObjectPool.Get();
            Console.WriteLine(obj3.MyId);

            var obj4 = customObjectPool.Get();
            Console.WriteLine(obj4.MyId);


        }

    }
}
