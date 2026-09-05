/*
 =======================================================================================
 CHALLENGE: RotateArray
 CATEGORY: CommonExercises / Easy-Array
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RotateArray problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.CommonExercises.RotateArrayTests
 =======================================================================================
*/

using System;

namespace CodingExercises.CommonExercises.Easy_Array
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            int count = 0;

            for (int start = 0; count < nums.Length; start++)
            {
                var current = start;
                var prev = nums[start];
             
                do
                {
                    var next = (current + k) % nums.Length;
                    int tmp = nums[next];
                    nums[next] = prev;
                    current = next;
                    prev = tmp;
                    count++;
                } while (current != start);
            }
        }

        public void RotateWithSpace(int[] nums, int k)
        {
            int[] aux = new int[nums.Length];
            k = k % nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                aux[(i + k) % nums.Length] = nums[i];
            }

            Array.Copy(aux, nums, aux.Length);
        }
    }
}
