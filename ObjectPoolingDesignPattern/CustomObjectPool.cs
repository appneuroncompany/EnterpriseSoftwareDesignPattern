using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace ObjectPoolingDesignPattern
{
    public class CustomObjectPool<T>
        where T: class, new()
    {
        private readonly ConcurrentBag<T> _objects;
        private readonly Func<T> _objectGenerator;
        public CustomObjectPool(Func<T> objectGenerator)
        {
            _objectGenerator = objectGenerator ?? throw new ArgumentException(nameof(objectGenerator));
            _objects = new ConcurrentBag<T>();
        }

        public T Get() => _objects.TryTake(out T item) ? item : _objectGenerator();
        public void Return(T item) => _objects.Add(item);
    }
}
