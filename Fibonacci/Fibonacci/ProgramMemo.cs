using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class ProgramMemo
    {
        public int FibMemo(int N)
        {
            return Fib(N, new int[N + 1]);
        }

        private int Fib(int i, int[] memo)
        {
            if (i == 0 || i == 1)
                return i;

            if (memo[i] == 0)
                memo[i] = Fib(i - 1, memo) + Fib(i - 2, memo);

            return memo[i];
        }
    }
}
