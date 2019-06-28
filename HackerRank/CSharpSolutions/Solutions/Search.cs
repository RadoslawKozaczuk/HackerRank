using System;

namespace CSharpSolutions.Solutions
{
    class Search
    {
        /*
            The best option is to sort the array, then walk two pointers inward from the ends of the array, at each point looking at their sum. 
            If it's exactly k, then we're done. If it exceeds k,then any sum using the larger element is too large, so we walk that pointer inwards. 
            If it's less than k, then any sum using the lower element is too small, so we walk that pointer inwards. 
            The runtime of this algorithm depends on the sorting algorithm used. Using a standard sorting algorithm, 
            this takes time O(n log n) due to the cost of sorting. 
        */
        public static void TwoSums(int[] cost, int money)
        {
            // we need an array of indexes
            int[] keys = new int[cost.Length];

            for (int i = 0; i < keys.Length; i++)
                keys[i] = i;

            Array.Sort(keys, (int a, int b) => 
            {
                if (cost[a] > cost[b])
                    return 1;
                else if (cost[a] == cost[b])
                    return 0;
                return -1;
            });

            int lhs = 0;
            int rhs = cost.Length - 1;

            while (lhs < rhs)
            {
                int sum = cost[keys[lhs]] + cost[keys[rhs]];
                if (sum == money)
                {
                    // output has to be in the ascending order
                    // +1 due to the task's requirements to used 1-based indexes in the response
                    string output = keys[lhs] < keys[rhs] 
                        ? $"{keys[lhs] + 1} {keys[rhs] + 1}" 
                        : $"{keys[rhs] + 1} {keys[lhs] + 1}";
                    Console.WriteLine(output);

                    return; // solution found
                }
                else if (sum < money)
                    lhs++;
                else
                    rhs--;
            }

            // if the program reach this it means no solution has been found
        }
    }
}
