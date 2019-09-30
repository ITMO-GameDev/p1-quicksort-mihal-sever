using System;
using System.Linq;
using QuickSort.Core;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] array = new int[100];
            for (int i = 0; i < array.Length; array[i++] = r.Next(30)) ;

            int[] arr2 = new int[100];
            array.CopyTo(arr2, 0);
            Array.Sort(arr2);
            Utility.PrintArray(arr2);

            Utility.PrintArray(array);
            Sort.QuickSortRecursive(array, 0, array.Length - 1);
            Utility.PrintArray(array);


            Console.WriteLine(arr2.SequenceEqual(array));

            Console.ReadKey();
        }
    }
}
