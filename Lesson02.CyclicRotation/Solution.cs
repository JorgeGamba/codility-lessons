namespace Lesson02.CyclicRotation
{
    public class Solution
    {
        public int[] solution(int[] A, int K)
        {
            var N = A.Length;
            if (N == 0 || K == N)
                return A;

            if (K > N)
                K %= N;

            int[] result = new int[N];
            for (int i = K; i < N; i++)
                result[i] = A[i - K];
            for (int i = 0; i < K; i++)
                result[i] = A[N - K + i];

            return result;
        }
    }
}
 