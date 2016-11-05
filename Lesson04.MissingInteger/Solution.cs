namespace Lesson04.MissingInteger
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int arrayLength = A.Length;
            int[] ocurrences = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                var value = A[i];
                if (value > 0 && value <= arrayLength)
                    ocurrences[value - 1]++;
            }
            for (int i = 0; i < ocurrences.Length; i++)
                if (ocurrences[i] == 0)
                    return i + 1;

            return arrayLength + 1;
        }
    }
}
 