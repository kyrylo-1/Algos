using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class BottomUpMemo
    {
        public int FibMemo(int N)
        {
            if (N == 0)
                return 0;

            if (N == 1)
                return 1;

            var memo = new int[N];
            memo[1] = 1;
            for (int i = 2; i < N; i++)
                memo[i] = memo[i - 1] + memo[i - 2];

            return memo[N - 1] + memo[N - 2];
        }
    }
}
