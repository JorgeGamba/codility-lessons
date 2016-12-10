namespace Lesson05.GenomicRangeQuery
{
    public class Solution
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            int prefixSumsSize = S.Length + 1;
            int[] aCounter = new int[prefixSumsSize];
            int[] cCounter = new int[prefixSumsSize];
            int[] gCounter = new int[prefixSumsSize];
            int[] tCounter = new int[prefixSumsSize];
            for (int i = 1; i < prefixSumsSize; i++)
            {
                aCounter[i] = S[i - 1] == 'A' ? aCounter[i - 1] + 1 : aCounter[i - 1];
                cCounter[i] = S[i - 1] == 'C' ? cCounter[i - 1] + 1 : cCounter[i - 1];
                gCounter[i] = S[i - 1] == 'G' ? gCounter[i - 1] + 1 : gCounter[i - 1];
                tCounter[i] = S[i - 1] == 'T' ? tCounter[i - 1] + 1 : tCounter[i - 1];
            }
            int M = P.Length;
            int[] result = new int[M];
            for (int i = 0; i < M; i++)
            {
                if (aCounter[Q[i] + 1] - aCounter[P[i]] > 0)
                    result[i] = 1;
                else if (cCounter[Q[i] + 1] - cCounter[P[i]] > 0)
                    result[i] = 2;
                else if (gCounter[Q[i] + 1] - gCounter[P[i]] > 0)
                    result[i] = 3;
                else if (tCounter[Q[i] + 1] - tCounter[P[i]] > 0)
                    result[i] = 4;
            }
            return result;
        }
    }
}
 