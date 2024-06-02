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
        private int nLength;
        private int mLength;

        public Indexers(T[,] array, int nIndex, int mIndex, int nLength, int mLenght)
        {
            if (nIndex < 0 || mIndex < 0 || nIndex > array.GetLength(0) || nIndex > array.GetLength(1))
            {
                throw new ArgumentException("Invalid arguments");
            }
            array.GetLength(0);
            this.array = array;
            this.nIndex = nIndex;
            this.mIndex = mIndex;
            this.nLength = nLength;
        }

        public int NLength
        {
            get { return nLength; }
        }

        public int MLength
        {
            get { return mLength; }
        }

        public T this[int nIndex, int mIndex]
        {
            // поиск N-го элемент в подмассиве
            get
            {
                if (nIndex < 0 || mIndex < 0 || nIndex > array.GetLength(0) || nIndex > array.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                return array[nIndex, mIndex];
            }

            // присваивание значения N-му элементу в подмассиве
            set
            {
                if (nIndex < 0 || mIndex < 0 || nIndex > array.GetLength(0) || nIndex > array.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                array[nIndex, mIndex] = value;
            }
        }
    }
}
