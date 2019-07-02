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
            var array = new char[] { 'd', 's', 'a', 'z', 'b' };
            //var array = new int[] { 1, 3, 5, 6, 7, 9 };
            Console.WriteLine("Before sorting");
            array.WriteEachElement();

            Console.WriteLine("\n\nAfter Countsort");
            array = new Program().Countsort(array);
            array.WriteEachElement();
        }

        public char[] Countsort(char[] arr)
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
    }
}
