using CSharpSolutions.Solutions;

namespace CSharpSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Dynamic Programming
            //int[] arr = new int[] { -2, 1, 3, -4, 5 }; // expected result: 8
            //int maxSum = DynamicProgramming.MaxArraySum(arr);
            //if (maxSum == 8)
            //    Console.WriteLine("Yeeey");


            int[][] table = new int[6][];
            table[0] = new int[] { 5, 1 };
            table[1] = new int[] { 2, 1 };
            table[2] = new int[] { 1, 1 };
            table[3] = new int[] { 8, 1 };
            table[4] = new int[] { 10, 0 };
            table[5] = new int[] { 5, 0 };
            int trol = GreedyAlgorithms.LuckBalance(3, table);


            int[] cost = new int[] { 1, 4, 5, 3, 2 };
            Search.TwoSums(cost, 4);

            int trdfgol = 92;
        }
    }
}
