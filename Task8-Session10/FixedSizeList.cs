using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_Session10
{
    public class FixedSizeList<T>
    {
        private T[] items;
        private int count;

        public FixedSizeList(int capacity)
        {
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                throw new InvalidOperationException("List is full.");
            }

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Invalid index.");
            }

            return items[index];
        }
    } 
}
