namespace Lesson01.BinaryGap
{
    class Solution
    {
        public int solution(int N)
        {
            int zeroCount = 0;
            int maxCount = 0;
            bool counting = false;
            while (N > 0)
            {
                int remain = N % 2;
                if (remain == 1)
                {
                    if (zeroCount > maxCount)
                        maxCount = zeroCount;
                    zeroCount = 0;
                    counting = true;
                }
                else if (counting)
                {
                    zeroCount++;
                }
                N /= 2;
            }

            return maxCount;
        }
    }
}