namespace Lesson03.TapeEquilibrium
{
    public class Solution
    {
        public int solution(int[] A)
        {
            var total = GetTotalFor(A);
            int bestDifference = int.MaxValue;
            int leftSum = 0, currentDifference;
            for (int p = 1; p < A.Length; p++)
            {
                leftSum += A[p - 1];
                currentDifference = Abs(leftSum * 2 - total);
                if (currentDifference < bestDifference)
                    bestDifference = currentDifference;
            }
            return bestDifference;
        }

        static int GetTotalFor(int[] A)
        {
            int total = 0;
            foreach (int value in A)
                total += value;
            return total;
        }

        int Abs(int formerValue) =>
            formerValue >= 0 ? formerValue : -formerValue;
    }
}
 