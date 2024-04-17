using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listTask
{

    public class Custom<T>
    {
        private int Count;
        private int Capacity;
        private T[] elements;
        public Custom()
        {
            Capacity = 4;
            Count = 0;
            elements = new T[Capacity];
        }
        public void Add(T element)
        {
            if (Count < Capacity)

            {
                elements[Count] = element;
                Count++;
            }
            else
            {
                int newCapacity = Capacity * 2;
                T[] newElements = new T[newCapacity];
                for (int i = 0; i < Count; i++)
                {
                    newElements[i] = elements[i];
                }
                newElements[Count] = element;
                Count++;
                elements = newElements;
                Capacity = newCapacity;

            }

        }
        public void ShowElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
        public T Find(Predicate<T> find)
        {
            foreach (T element in elements)
            {
                if (find(element))
                {
                    return element;
                }
            }
            return default(T);


        }
        public List<T> FindAll(Predicate<T> find)
        {
            List<T> findElements = new List<T>();

            foreach (T element in elements)
            {
                if (find(element))
                {
                    findElements.Add(element);
                }
            }
            return findElements;




        }
    }
}
