using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Homework.Work11
{
    public class MyList<T>
    {
        public T[] _items;
        public int _count { get; set; }

        public int getCount()
        {
            return _count;
        }

        public MyList(int capacity = 5)
        {
            _items = new T[capacity];
            _count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
                yield return _items[i];
        }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                _items[index] = value;
            }
        }
        public void Add(T item)
        {
            if(_items.Length == _count)
            {
                int newCapacity;
                if (_items.Length == 0)
                {
                    newCapacity = 4;
                }
                else
                {
                    newCapacity = _items.Length * 2;
                }

                T[] newItems = new T[newCapacity];

                for (int i = 0; i < _count; i++)
                {
                    newItems[i] = _items[i];
                }

                _items = newItems;
            }
            _items[_count] = item;
            _count++;
        }

    }
}
