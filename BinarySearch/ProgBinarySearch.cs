using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace BinarySearch
{
    class ProgBinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -1, 4, 30, 39, 83, 93, 100 };
            ArrayTools.WriteEachElement(arr);
            int item = 4;
            Console.WriteLine("\nItem: " + item + " is on " + BinarySearch(arr, item) + " place");
        }

        public static int BinarySearch(int[] arr, int item)
        {
            int lowIndex = 0;
            int highIndex = arr.Length - 1;

            while (lowIndex <= highIndex)
            {
                int midIndex = (lowIndex + highIndex) / 2;
                int guess = arr[midIndex];

                if (guess == item)
                    return midIndex;

                if (guess > item)
                    highIndex = midIndex - 1;

                else
                    lowIndex = midIndex + 1;
            }

            return -1;
        }
    }
}
