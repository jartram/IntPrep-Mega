/*
 =======================================================================================
 CHALLENGE: RevereString2
 CATEGORY: MicrosoftExcercises / Easy
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RevereString2 problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.RevereString2Tests
 =======================================================================================
*/

using System.Text;

public class RevereString2
{
    public string ReverseStr(string s, int k)
    {
        var result = new StringBuilder();

        int i = 0;

        while (i < s.Length)
        {
            if (i % (2 * k) == 0)
            {
                Reverse(s, i, k, result);

                i = i + k;
            }
            else
            {
                result.Append(s[i]);

                i++;
            }
        }

        return result.ToString();
    }

    public void Reverse(string s, int start, int k, StringBuilder sb)
    {
        var end = start + k > s.Length ? s.Length : start + k;

        for (int i = end - 1; i >= start; i--)
        {
            sb.Append(s[i]);
        }
    }
}
