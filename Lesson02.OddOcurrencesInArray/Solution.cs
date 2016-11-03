namespace Lesson02.OddOcurrencesInArray
{
    class Solution
    {
        public int solution(int[] A)
        {
            var result = A[0];
            for (int i = 1; i < A.Length; i++)
                result ^= A[i];

            return result;
        }
    }
}
