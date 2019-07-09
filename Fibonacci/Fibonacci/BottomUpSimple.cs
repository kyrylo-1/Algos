using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class BottomUpSimple
    {
        public int Fib(int N)
        {
            if (N == 0)
                return 0;

            int a = 0;
            int b = 1;

            for (int i = 2; i < N; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            return a + b;
        }
    }
}
