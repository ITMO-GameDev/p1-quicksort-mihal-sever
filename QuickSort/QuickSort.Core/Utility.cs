using System;

namespace QuickSort.Core
{
    public static class Utility
    {
        private static Random rand = new Random();

        public static void PrintArray<T>(T[] array)
        {
            string s = "";
            foreach (T t in array)
            {
                s += $" {t}";
            }
            Console.WriteLine(s);
        }

        public static int[] CreateRandomIntArray(int size, int maxValue, int minValue = 0)
        {
            if (minValue > maxValue)
            {
                Swap(ref minValue, ref maxValue);
            }
            
            int[] array = new int[size];
            for (int i = 0; i < array.Length; array[i++] = rand.Next(minValue, maxValue)) ;
            return array;
        }

        public static double[] CreateRandomDoubleArray(int size, double maxValue, double minValue = 0)
        {
            if (minValue > maxValue)
            {
                Swap(ref minValue, ref maxValue);
            }
            
            double[] array = new double[size];
            for (int i = 0; i < array.Length; array[i++] = minValue + rand.NextDouble() *(maxValue - minValue)) ;
            return array;
        }

        public static T[] CopyArray<T>(T[] originalArray)
        {
            T[] array = new T[originalArray.Length];
            originalArray.CopyTo(array, 0);
            return array;
        }

        public static void Swap<T>(ref T t1, ref T t2)
        {
            T t = t1;
            t1 = t2;
            t2 = t;
        }
    }
}
