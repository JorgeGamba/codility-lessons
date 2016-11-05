namespace Lesson04.FrogRiverOne
{
    public class Solution
    {
        public int solution(int X, int[] A)
        {
            var arrayLength = A.Length;
            if (arrayLength >= X)
            {
                int[] steps = new int[X];
                int lastCompletedStep = 0;
                for (int i = 0; i < arrayLength; i++)
                {
                    int currentValue = A[i];
                    if (currentValue <= X)
                    {
                        steps[currentValue - 1]++;
                        lastCompletedStep = GetTheLastCompletedStepGiven(steps, lastCompletedStep);
                        if (lastCompletedStep == X)
                            return i;
                    }
                }
            }
            return -1;
        }

        int GetTheLastCompletedStepGiven(int[] steps, int lastCompletedStep)
        {
            for (int i = lastCompletedStep; i <= steps.Length - 1; i++)
            {
                if (steps[i] == 0)
                    return lastCompletedStep;
                lastCompletedStep++;
            }
            return lastCompletedStep;
        }
    }
}
 