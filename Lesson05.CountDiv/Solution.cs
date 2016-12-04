namespace Lesson05.CountDiv
{
    public class Solution
    {
        public int solution(int A, int B, int K)
        {
            int aDivisibleCount = GetDivisibleCountGiven(A - 1, K);
            int bDivisibleCount = GetDivisibleCountGiven(B, K);

            return bDivisibleCount - aDivisibleCount;
        }

        int GetDivisibleCountGiven(int order, int divisor) =>
            order < 0 ? 0 : order / divisor + 1;
    }
}
 