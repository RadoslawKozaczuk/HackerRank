using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSolutions.Solutions
{
    class Miscellaneous
    {
        /// <summary>
        /// Returns "Prime" if the given number is a prime number, "Not prime" otherwise.
        /// n >= 1 && <= 10^9.
        /// </summary>
        public static string IsPrimeNumber(int n)
        {
            if(n == 1)
                return "Not prime";

            if (n <= 3)
                return "Prime";

            for(int i = 2; i <= (int)Math.Sqrt(n); i++)
                if (n % i == 0)
                    return "Not prime";

            return "Prime"; 
        }
    }
}
