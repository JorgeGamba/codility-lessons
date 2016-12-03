namespace Lesson04.PermCheck
{
    public class Solution
    {
        public int solution(int[] A)
        {
            var N = A.Length;
            int[] counter = new int[N];
            foreach (var value in A)
            {
                var index = value - 1;
                if (value > N || counter[index] > 0)
                    return 0;
                counter[index]++;
            }
            return 1;
        }
    }
}
 