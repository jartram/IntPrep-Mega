/*
 =======================================================================================
 CHALLENGE: BiggestNumber (08-making-decisions)
 CHAPTER: Chapter08_MakingDecisions
 
 DESCRIPTION:
 * ---
 * name: Biggest Number
 * description: Biggest number out of 3.
 * details: ./07_making_decisions/biggest_number/README.md
 * difficulty: Medium
 * solution: false
 * unitTests: true
 * keywords: operators
 * solved: false
 * notes:
 * ---
 *
 * # Biggest Number
 *
 * The Biggest Number app allows you to determine the biggest number out of three. However its lacking some implementation.
 *
 * Add the logic to determine the biggest number inside of the method `DetermineBiggest` of the class `Biggest`. Make sure that it also works with negative numbers.
 *
 * Example output:
 *
 * ```text
 * The biggest number of (1, -3, 104) = 104
 * The biggest number of (-5, 11, 3) = 11
 * The biggest number of (0, 109, 66) = 109
 * ```
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CSharpPractical.Tests.Chapter08_MakingDecisions.BiggestNumber.UnitTestBiggest
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter08_MakingDecisions.BiggestNumber
{
    public class Biggest
    {
        public int DetermineBiggest(int first, int second, int third)
        {
            // TODO Determine the biggest number of the three
            int biggest = 0;

            // Please dont change the code below (automatic unit tests)
            return biggest;
        }
    }
}
