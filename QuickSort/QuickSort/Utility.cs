using System;

namespace QuickSort
{
    public static class Utility
    {
        public static void PrintArray<T>(T[] array)
        {
            string s = "";
            foreach (T t in array)
            {
                s += $" {t}";
            }
            Console.WriteLine(s);
        }
    }
}
