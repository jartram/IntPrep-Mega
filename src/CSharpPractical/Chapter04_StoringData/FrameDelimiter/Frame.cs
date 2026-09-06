/*
 =======================================================================================
 CHALLENGE: FrameDelimiter (04-storing-data)
 CHAPTER: Chapter04_StoringData
 
 DESCRIPTION:
 * # Frame Delimiter
 *
 * Frame delimiters are often used in communication protocols. They denote the start and end of a piece of data that is being transmitted.
 *
 * This application models the beginning of such a data frame.
 *
 * A frame
 *
 * * starts with the value `0xAA`
 * * ends with the value `0x55`
 *
 * Initialize the variables `startOfFrame` and `endOfFrame` so they both have the correct value.
 *
 * Change the code in the method `StartOfFrame` and `EndOfFrame` in the file `FrameDelimiter\Frame.cs`.
 *
 * Don't worry that both values print as decimals. Expected output:
 *
 * ```text
 * A frame always starts with: 170
 * A frame always ends with: 85
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter04_StoringData.FrameDelimiter.FrameTest
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter04_StoringData.FrameDelimiter
{
    public class Frame
    {
        public byte StartOfFrame()
        {
            // TODO: Set start of frame delimiter to AA hexadecimal
            byte startOfFrame = 0;

            Console.WriteLine("A frame always starts with: " + startOfFrame);

            // Please dont change the code below (automatic unit tests)
            return startOfFrame;
        }

        public byte EndOfFrame()
        {
            // TODO: Set end of frame delimiter to 55 hexadecimal
            byte endOfFrame = 0;

            Console.WriteLine("A frame always ends with: " + endOfFrame);

            // Please dont change the code below (automatic unit tests)
            return endOfFrame;
        }
    }
}
