using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    //509. Fibonacci Number on Leetcode
    public class Program
    {
        static void Main(string[] args)
        {
        }


        //the simplest recursive solution
        public int FibRecursive(int N)
        {
            if (N == 0)
                return 0;

            if (N == 1)
                return 1;

            return FibRecursive(N - 1) + FibRecursive(N - 2);
        }

    }
}
