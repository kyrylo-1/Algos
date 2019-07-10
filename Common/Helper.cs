using System;
using System.Collections.Generic;

namespace Common
{
    public static class ArrayTools
    {
        static void Main(string[] args)
        {

        }

        /// <summary>
        /// Swaps two values in an IList<T> collection given their indexes.
        /// </summary>
        public static void Swap<T>(this IList<T> list, int firstIndex, int secondIndex)
        {
            if (list.Count < 2 || firstIndex == secondIndex)   //This check is not required but Partition function may make many calls so its for perf reason
                return;

            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        /// <summary>
        /// Swaps two values in an array collection given their indexes.
        /// </summary>
        public static void Swap<T>(this T[] list, int firstIndex, int secondIndex)
        {
            if (list.Length < 2 || firstIndex == secondIndex)   //This check is not required but Partition function may make many calls so its for perf reason
                return;

            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        public static void WriteEachElement<T>(this T[] array)
        {
            if (array == null)
                return;

            foreach (var item in array)
                Console.Write(item.ToString() + " ");            
        }

        public static void WriteEachElement<T>(this List<T> list)
        {
            if (list == null)
                return;

            foreach (var item in list)
                Console.Write(item.ToString() + " ");
        }

        /// <summary>
        /// Populates a collection with a specific value.
        /// </summary>
        public static void Populate<T>(this IList<T> collection, T value)
        {
            if (collection == null)
                return;

            for (int i = 0; i < collection.Count; i++)
            {
                collection[i] = value;
            }
        }
    }
}
