namespace CodingExercises.Solutions.CommonExercises.Easy_Array
{
    // https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/567/
    public class MoveZeroes
    {
        public void Move(int[] nums)
        {
            var fillIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (fillIndex != i)
                    {
                        nums[fillIndex] = nums[i];
                        nums[i] = 0;
                    }

                    fillIndex++;
                }
            }
        }
    }
}
