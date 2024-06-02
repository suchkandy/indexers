using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Indexers<T>
    {
        private T[,] array;
        private int nIndex;
        private int mIndex;
        private int length;

        public Indexers(T[,] array, int nIndex, int mIndex, int length)
        {
            if (nIndex < 0 || mIndex < 0 || nIndex*mIndex > array.Length || length < 1)
            {
                throw new ArgumentException("Invalid arguments");
            }
            array.GetLength(0);
            this.array = array;
            this.nIndex = nIndex;
            this.mIndex = mIndex;
            this.length = length;
        }

        public int Length
        {
            get { return length; }
        }

        public T this[int nIndex, int mIndex]
        {
            // поиск N-го элемент в подмассиве
            get
            {
                if (nIndex < 0 || mIndex < 0 || nIndex * mIndex >= length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                return array[nIndex, mIndex];
            }

            // присваивание значения N-му элементу в подмассиве
            set
            {
                if (nIndex < 0 || mIndex < 0 || nIndex * mIndex >= length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                array[nIndex, mIndex] = value;
            }
        }
    }
}
