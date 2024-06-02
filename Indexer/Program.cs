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
            int[,] array = { { 1, 2 }, { 3, 4 } };
            Indexers<int> indexers = new Indexers<int>(array, 2, 2, 4);

            Console.WriteLine("Длина подмножества: " + indexers.Length);

            Console.WriteLine("Первый элемент: " + indexers[0, 0]);

            // устанавливаем второй элемент равным 3
            indexers[1, 1] = 3;

            Console.WriteLine("Второй элемент после установки: " + indexers[1, 1]);

            Console.ReadKey();
        }
    }
}