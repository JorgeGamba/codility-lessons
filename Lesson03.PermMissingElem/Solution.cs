namespace Lesson03.PermMissingElem
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int total = 1;
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                total += i + 2;
                sum += A[i];
            }
            return total - sum;
        }
    }
}
 