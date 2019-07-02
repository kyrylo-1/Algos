using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace InsertionSort
{
    /// <summary>
    /// Class contains variations of insertionSort. 
    /// Time complexity: Best: O(n), worst  O(n^2). Space complexity: O(1)
    /// https://www.youtube.com/watch?v=DFG-XuyPYUQ&t=9s
    /// </summary>
    class EntryInsertionSort
    {
        static void Main(string[] args)
        {
            var array = new int[] { 3, 9, 1, 34, 9, 10, -3 };
            //var array = new int[] { 1, 3, 5, 6, 7, 9 };
            Console.WriteLine("Before sorting");
            array.WriteEachElement();

            Console.WriteLine("\n\nAfter InsertSort");
            Sort(array);
            array.WriteEachElement();
        }

        public static void Sort(int[] array)
        {
            int len = array.Length;
            for (int i = 1; i < len; i++)
            {
                int iElement = array[i];
                int j = i;

                while (j > 0 && array[j - 1] > iElement)
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = iElement;
            }
        }
    }
}
