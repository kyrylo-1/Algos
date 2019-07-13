using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace CountSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var array = new char[] { 'd', 's', 'a', 'z', 'b' };

            //Console.WriteLine("Before sorting");
            //array.WriteEachElement();

            //Console.WriteLine("\n\nAfter Countsort");
            //array = new Program().CountsortLetters(array);
            //array.WriteEachElement();

            var array = new int[] { 4, 8, 4, 2, 9, 9, 6, 2, 9 };

            Console.WriteLine("Before sorting");
            array.WriteEachElement();

            Console.WriteLine("\n\nAfter Countsort");
            array = new Program().CountsortNumbers(array);
            array.WriteEachElement();
        }

        public char[] CountsortLetters(char[] arr)
        {
            char[] output = new char[arr.Length];
            int[] count = new int[26];

            for (int i = 0; i < arr.Length; ++i)
                count[arr[i] - 'a']++;


            for (int i = 0, j = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                    output[j++] = (char)(i + 'a');
            }

            return output;
        }


        public int[] CountsortNumbers(int[] arr)
        {
            int min = arr.Min();
            int range = arr.Max() - min + 1;
            var count = new int[range];
            var output = new int[arr.Length];

            for (int i = 0; i < output.Length; i++)
            {
                int index = arr[i] - min;
                count[index]++;
            }
            for (int i = 1; i < count.Length; i++)
                count[i] += count[i - 1];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int index = arr[i] - min;
                int countNumb = count[index];
                output[countNumb - 1] = arr[i];
                count[index]--;
            }

            Array.Copy(output, arr, arr.Length);

            return output;
        }
    }
}
