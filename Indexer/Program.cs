using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indexers;

namespace classIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 2, 3 }, { 3, 4, 5 } };
            Indexers<int> indexers = new Indexers<int>(array, 2, 3, 2, 3);

            // устанавливаем первый элемент равным 2
            indexers[0, 0] = 2;

            Console.WriteLine("Длина подмножества: " + indexers.NLength * indexers.MLength);

            Console.WriteLine("Первый элемент: " + indexers[0, 0]);

            // устанавливаем последний элемент равным 3
            indexers[1, 2] = 3;

            Console.WriteLine("Второй элемент после установки: " + indexers[1, 2]);

            Console.ReadKey();
        }
    }
}