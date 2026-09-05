namespace CodingExercises.Solutions.CommonExercises.Easy_Array
{
    public class SingleNumberInArray
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }

            return result;
        }
    }
}
