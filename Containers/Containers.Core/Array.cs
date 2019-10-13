using System;
using System.Collections.Generic;

namespace Containers.Core
{
    public sealed class Array<T>
    {
        private List<T> array;

        /// <summary>
        /// Creates empty array of elements of type T.
        /// </summary>
        public Array()
        {
            array = new List<T>();
        }

        /// <summary>
        /// Creates array of elements of type T of given size.
        /// </summary>
        /// <param name="capacity">Number of elements.</param>
        public Array(int capacity)
        {
            array = new List<T>();
            for (int i = 0; i < capacity; i++)
                array.Add(default(T));
        }

        /// <summary>
        /// Destructor. Does nothing.
        /// </summary>
        ~Array() => Console.WriteLine("Destructor has been called. C# does not require manual memory cleaning, " +
            "because Garbage Collector does it for us.");

        /// <summary>
        /// Inserts value at the end of the array.
        /// </summary>
        /// <param name="value">Value to insert.</param>
        public void Insert(T value)
        {
            array.Add(value);
        }

        /// <summary>
        /// Inserts value in the array at given position.
        /// </summary>
        /// <param name="index">Position to insert.</param>
        /// <param name="value">Value to insert.</param>
        public void Insert(int index, T value)
        {
            array.Insert(index, value);
        }

        /// <summary>
        /// Removes array element at given position.
        /// </summary>
        /// <param name="index">Position to remove.</param>
        public void Remove(int index)
        {
            array.RemoveAt(index);
        }

        /// <summary>
        /// Indexer to access array members.
        /// </summary>
        /// <param name="i">Index.</param>
        /// <returns>Array element at index.</returns>
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        /// <summary>
        /// Returns array size.
        /// </summary>
        public int Size() => array.Count;

        /// <summary>
        /// Returns array iterator.
        /// </summary>
        public Iterator GetIterator()
        {
            return new Iterator(array);
        }

        /// <summary>
        /// Array ierator class.
        /// </summary>
        public class Iterator
        {
            private List<T> array;
            private int index = 0;

            public Iterator(List<T> array)
            {
                this.array = array;
            }

            public void Next() => index++;

            public void Prev() => index--;

            public T Get() => array[index];

            public void Set(T value) => array[index] = value;

            public void Insert(T value) => array.Insert(index, value);

            public void Remove() => array.RemoveAt(index);

            public void ToIndex(int index) => this.index = index;

            public bool HasNext() => index < array.Count;

            public bool HasPrev() => index > 0;
        }
    }
}
