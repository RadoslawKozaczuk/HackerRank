using System.Collections.Generic;

namespace CSharpSolutions
{
    class GreedyAlgorithms
    {
        public static int LuckBalance(int k, int[][] contests)
        {
            int accumulatedLuck = 0;
            var importantContests = new List<int>();

            for (int i = 0; i < contests.Length; i++)
            {
                if(contests[i][1] == 0) // unimportant
                    accumulatedLuck += contests[i][0];
                else
                    importantContests.Add(contests[i][0]);
            }

            importantContests.Sort();

            int border = importantContests.Count - k;
            for (int i = 0; i < importantContests.Count; i++)
            {
                if(i < border)
                    accumulatedLuck -= importantContests[i];
                else
                    accumulatedLuck += importantContests[i];
            }

            return accumulatedLuck;
        }
    }
}
