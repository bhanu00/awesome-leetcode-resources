namespace ArrayPractice
{
    public class ArrayNumberProblems
    {
        /// <summary>
        /// Problem Statement: Given an array of integers numbers that is already sorted in non-decreasing order, 
        /// find two numbers such that they add up to a specific target number. Return the indices of the two numbers.
        /// -- Two pointer technique
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int[] TwoNumbersSumToTarget(int[] numbers, int target)
        {
            int left = 0, right = numbers.Length - 1;
            // for example [2,3,4,5,9,10]

            for (int i = left; i <= right; i++)
            {
                int sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    return [left, right];
                }
                else if (target < sum)
                    right--;
                else
                    left++;
            }
            return [];
        }
    }
}
