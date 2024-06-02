using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classIndexers;

namespace classIndexers
{
    public class Indexer <T>
    {
        private T[] array;
        private int startIndex;
        private int length;

        public Indexer(T[] array, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex + length > array.Length || length < 1)
            {
                throw new ArgumentException("Invalid arguments");
            }

            this.array = array;
            this.startIndex = startIndex;
            this.length = length;
        }

        public int Length
        {
            get { return length; }
        }

        public T this[int index]
        {
            // поиск N-го элемент в подмассиве
            get
            {
                if (index < 0 || index >= length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                return array[startIndex + index];
            }

            // присваивание значения N-му элементу в подмассиве
            set
            {
                if (index < 0 || index >= length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                array[startIndex + index] = value;
            }
        }
    }
}