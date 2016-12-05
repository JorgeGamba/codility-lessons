namespace Lesson05.PassingCars
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int travelingToWestCount = 0;
            int passingCarsCount = 0;
            foreach (var item in A)
            {
                if (item == 0)
                    travelingToWestCount++;
                else
                    passingCarsCount += travelingToWestCount;

                if (passingCarsCount > 1000000000)
                    return -1;
            }

            return passingCarsCount;
        }
    }
}
 