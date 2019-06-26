using System;

namespace CSharpSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dynamic Programming
            int[] arr = new int[] { -2, 1, 3, -4, 5 }; // expected result: 8
            int maxSum = DynamicProgramming.DynamicProgramming.MaxArraySum(arr);
            if (maxSum == 8)
                Console.WriteLine("Yeeey");
        }
    }
}
