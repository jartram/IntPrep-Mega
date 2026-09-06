/*
 =======================================================================================
 CHALLENGE: RestoreIpAddress
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the RestoreIpAddress problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExercises.RestoreIpAddressTests
 =======================================================================================
*/

﻿using System.Collections.Generic;
using System.Text;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class RestoreIpAddress
    {
        public IList<string> result;

        public IList<string> RestoreIpAddresses(string s)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public void Backtrack(string s, string[] actualIp, int buildIndex, int bucket)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public bool IsValid(string number)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}


public class RestoreIpAddresses
{
    public IList<string> RestoreIpAddressesReview(string s)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    public void Backtrack(string str, int start, int blockCount, string[] blocks, List<string> restored)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    private bool isValid(string block)
    {
        var num = int.Parse(block);

        return num >= 0 && num <= 255 && num.ToString().Length == block.Length;
    }
}