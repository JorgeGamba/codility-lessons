namespace Lesson05.MinAvgTwoSlice
{
    public class Solution
    {
        public int solution(int[] A)
        {
            float currentMinAverage = (float) (A[0] + A[1]) / 2;
            int currentMinAveragePosition = 0;
            float currentLastTwoAverage, currentLastThreeAverage;
            for (int i = 2; i < A.Length; i++)
            {
                currentLastTwoAverage = (float) (A[i] + A[i - 1]) / 2;
                if (currentLastTwoAverage < currentMinAverage)
                {
                    currentMinAveragePosition = i - 1;
                    currentMinAverage = currentLastTwoAverage;
                }
                currentLastThreeAverage = (float) (A[i] + A[i - 1] + A[i - 2]) / 3;
                if (currentLastThreeAverage < currentMinAverage)
                {
                    currentMinAveragePosition = i - 2;
                    currentMinAverage = currentLastThreeAverage;
                }
            }

            return currentMinAveragePosition;
        }
    }
}
 