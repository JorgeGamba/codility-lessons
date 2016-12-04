namespace Lesson04.MaxCounters
{
    public class Solution
    {
        public int[] solution(int N, int[] A)
        {
            int[] counters = new int[N];
            int M = A.Length;
            int maxCounter = 0;
            int lastResetCounter = 0;
            for (int i = 0; i < M; i++)
            {
                if (A[i] > N)
                    lastResetCounter = maxCounter;
                else
                {
                    var index = A[i] - 1;
                    if (counters[index] < lastResetCounter)
                        counters[index] = lastResetCounter + 1;
                    else
                        counters[index]++;

                    if (counters[index] > maxCounter)
                        maxCounter = counters[index];
                }
            }
            for (int i = 0; i < N; i++)
                if (counters[i] < lastResetCounter)
                    counters[i] = lastResetCounter;

            return counters;
        }
    }
}
 