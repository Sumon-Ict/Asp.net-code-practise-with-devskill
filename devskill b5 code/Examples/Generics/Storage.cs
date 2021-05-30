using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Storage<T>
    {
        private T[] _items;

        public Storage(int size)
        {
            _items = new T[size];
        }

        public void PutItem(int index, T itemValue)
        {
            _items[index] = itemValue;
        }

        public T GetItem(int index)
        {
            return _items[index];
        }
    }
}
