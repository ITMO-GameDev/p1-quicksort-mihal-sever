using System;
using QuickSort.Core;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Utility.CreateRandomIntArray(100, 1000);

            Console.WriteLine("Initial array:");
            Utility.PrintArray(array);

            Sort.QuickSortRecursive(array, 0, array.Length - 1);

            Console.WriteLine("Sorted array:");
            Utility.PrintArray(array);
            
            Console.ReadKey();
        }
    }
}
