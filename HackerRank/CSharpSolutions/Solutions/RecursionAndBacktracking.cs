using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Solutions
{
    class RecursionAndBacktracking
    {
        /// <summary>
        /// Returns n'th Fibonacci's number
        /// </summary>
        public static int FibonaccisNumbers(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibonaccisNumbers(n - 2) + FibonaccisNumbers(n - 1);
        }
    }
}
