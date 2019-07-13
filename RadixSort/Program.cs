using System;
using System.Collections.Generic;
using System.Linq;
using Common;
namespace RadixSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 53, 89, 150, 36, 633, 233 };
            Console.WriteLine("Before sorting");
            arr.WriteEachElement();

            Console.WriteLine("\n\nAfter BubbleSortAscending");
            new Program().RadixSort2(arr);
            arr.WriteEachElement();
        }


        public void RadixSort2(int[] nums)
        {
            int digitPlace = 1;
            int len = nums.Length;
            var result = new int[len];

            // Find the largest number to know number of digits
            int largestNum = nums.Max();

            //we run loop until we reach the largest digit place
            while (largestNum / digitPlace > 0)
            {
                var count = new int[10];

                //Store the count of "keys" or digits in count[]
                for (int i = 0; i < len; i++)
                {
                    int digit = (nums[i] / digitPlace) % 10;
                    count[digit]++;
                }

                // Change count[i] so that count[i] now contains actual
                //  position of this digit in result[]
                //  Working similar to the counting sort algorithm
                for (int i = 1; i < 10; i++)
                    count[i] += count[i - 1];

                // Build the resulting array
                for (int i = len - 1; i >= 0; i--)
                {
                    int digit = (nums[i] / digitPlace) % 10;
                    int indexRes = count[digit] - 1;
                    result[indexRes] = nums[i];
                    count[digit]--;
                }

                Array.Copy(result, nums, len);

                // Move to next digit place
                digitPlace *= 10;
            }
        }

        //from geeks for geek
        public void RadixSort(int[] nums)
        {
            int max = nums.Max();

            for (int exp = 1; max / exp > 0; exp *= 10)
                CountSort(nums, exp);
        }

        public static void CountSort(int[] arr, int exp)
        {
            int len = arr.Length;
            var output = new int[len];
            var count = new int[10];

            // Store count of occurrences in count[]  
            for (int i = 0; i < len; i++)
                count[(arr[i] / exp) % 10]++;

            // Change count[i] so that count[i] now contains actual  
            //  position of this digit in output[]  
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build the output array  
            for (int i = len - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }

             Array.Copy(output, arr, len);
        }

    }
}
