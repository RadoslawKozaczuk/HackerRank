using System;

namespace CSharpSolutions
{
    class DynamicProgramming
    {
        /*
            Difficulty : Medium (HackerRank)
            Given an array of integers, find the subset of non-adjacent elements with the maximum sum. Calculate the sum of that subset.
            For example, given an array we have the following possible subsets:

            Set: [-2,1,3,-4,5]

            Subset      Sum
            [-2, 3, 5]   6
            [-2, 3]      1
            [-2, -4]    -6
            [-2, 5]      3
            [1, -4]     -3
            [1, 5]       6
            [3, 5]       8

            Our maximum subset sum is 8.
        */
        public static int MaxArraySum(int[] arr)
        {
            int inclusive = arr[0]; // maximum sum of all preceding elements including this element
            int exclusive = 0; // maximum sum of all preceding elements excluding this element
            int exclusiveNew;

            // this algorithm always check if it is more profitable to skip previously included value 
            // and instead add pre-previous value and the current value
            // thanks to that we are guaranteed to always have a space in between because even if both values are
            // profitable only the biggest one can be taken
            for (int i = 1; i < arr.Length; i++)
            {
                // current max excluding i
                exclusiveNew = (inclusive > exclusive) ? inclusive : exclusive;

                // current max including i
                inclusive = exclusive + arr[i];
                exclusive = exclusiveNew;

                Console.WriteLine("exclusiveNew: " + exclusiveNew);
                Console.WriteLine("exclusive: " + exclusive);
                Console.WriteLine("inclusive: " + inclusive);
            }

            // return max of inclusive and exclusive
            return (inclusive > exclusive) ? inclusive : exclusive;
        }
    }
}
