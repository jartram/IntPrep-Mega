using System.Collections.Generic;

namespace CodingExercises.Solutions.MicrosoftExcercises.Medium
{
    public class TaskScheduler
    {
        public int LeastInterval(char[] tasks, int n)
        {
            var freq = new Dictionary<char, int>();
            int maxFreq = 0;
            int countMax = 0;

            foreach (var task in tasks)
            {
                if (!freq.ContainsKey(task))
                {
                    freq.Add(task, 0);
                }

                freq[task]++;

                if (freq[task] > maxFreq)
                {
                    maxFreq = freq[task];
                    countMax = 0;
                }
                else if (freq[task] == maxFreq)
                {
                    countMax++;
                }
            }

            var result = (maxFreq - 1) * n + maxFreq + countMax;

            if (result < tasks.Length)
            {
                result += tasks.Length - result;
            }

            return result;
        }
    }
}
