using System;

namespace CodingExercises.Solutions.CommonExercises.Hard_Array
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var maxArea = 0;
            var i = 0;
            var j = height.Length - 1;

            while (i < j)
            {
                var hI = height[i];
                var hJ = height[j];

                maxArea = Math.Max(maxArea, Math.Min(hI, hJ) * (j - i));

                if (hI < hJ)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return maxArea;
        }
    }
}
