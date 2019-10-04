using System;
using System.Collections.Generic;

namespace QuickSort.Core
{
    public static class Sort
    {
        public static void QuickSortRecursive<T>(T[] arr, int first, int last) where T : IComparable
        {
            if (last <= first)
                return;

            if (last - first < 11)
            {
                InsertionSort(arr, first, last);
                return;
            }

            int i = Partition(arr, first, last);

            if (i - first > last - i)
            {
                QuickSortIterative(arr, first, i);
                QuickSortRecursive(arr, i + 1, last);
            }
            else
            {
                QuickSortRecursive(arr, first, i);
                QuickSortIterative(arr, i + 1, last);
            }
        }

        public static void InsertionSort<T>(T[] arr, int first, int last) where T : IComparable
        {
            for (int i = first + 1; i < last + 1; i++)
            {
                for (int j = i; j > first; j--)
                {
                    if (arr[j - 1].CompareTo(arr[j]) > 0)
                    {
                        Utility.Swap(ref arr[j], ref arr[j - 1]);
                    }
                }
            }
        }

        public static void QuickSortIterative<T>(T[] arr, int first, int last) where T : IComparable
        {
            Stack<Tuple<int, int>> s = new Stack<Tuple<int, int>>();
            s.Push(new Tuple<int, int>(first, last));

            while (s.Count > 0)
            {
                (first, last) = s.Pop();

                if (last <= first)
                    continue;

                int i = Partition(arr, first, last);

                if (i - first > last - i)
                {
                    s.Push(new Tuple<int, int>(first, i));
                    s.Push(new Tuple<int, int>(i + 1, last));
                }
                else
                {
                    s.Push(new Tuple<int, int>(i + 1, last));
                    s.Push(new Tuple<int, int>(first, i));
                }
            }

        }

        private static int Partition<T>(T[] arr, int first, int last) where T : IComparable
        {
            int f = first, l = last;
            T pivot = GetMedian(arr[f], arr[(f + l) / 2], arr[l]);

            while (f <= l)
            {
                while (arr[f].CompareTo(pivot) < 0) f++;
                while (arr[l].CompareTo(pivot) > 0) l--;

                if (f >= l)
                    break;

                Utility.Swap(ref arr[f++], ref arr[l--]);
            }
            return l;
        }

        private static T GetMedian<T>(params T[] arr) where T : IComparable
        {
            InsertionSort(arr, 0, arr.Length - 1);
            return arr[arr.Length / 2];
        }
    }
}
