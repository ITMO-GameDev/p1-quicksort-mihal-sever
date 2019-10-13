using System;
using Containers.Core;

namespace Containers
{
    class Program
    {
        static void Main(string[] args)
        {

            Array<int> arr = new Array<int>();

            for (int i = 0; i < 10; i++)
                arr.Insert(i);
            
            for (int i = 0; i < arr.Size(); ++i)
                arr[i] *= 2;
            
            for (var it = arr.GetIterator(); it.HasNext(); it.Next())
                Console.WriteLine(it.Get());
        }
    }
}
