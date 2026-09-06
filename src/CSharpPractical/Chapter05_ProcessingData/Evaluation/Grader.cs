/*
 =======================================================================================
 CHALLENGE: Evaluation (05-processing-data)
 CHAPTER: Chapter05_ProcessingData
 
 DESCRIPTION:
 * # Evaluation
 *
 * The evaluation app is a tool that calculates the average score and total score of a student for the course "Introduction to Programming". The total score is however not equal to the average but takes the following distribution into account:
 *
 * * The exam counts for `40%` of the total score
 * * The lab counts for `60%` of the total score
 *
 * Both the average and total score should return a value based on a score of `/20`. You can find the methods inside of the file `Evaluation\Grader.cs`.
 *
 * Example:
 *
 * ```text
 * Lenny Dermond:
 *     Exam Score: 13.5/20
 *     LAB Score: 16.2/20
 *     Average Score: 14.85
 *     Total Score: 15.12
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter05_ProcessingData.Evaluation.UnitTestGrader
 =======================================================================================
*/

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractical.Chapter05_ProcessingData.Evaluation
{
    public class Grader
    {
        double examScore = 13.5;
        double labScore = 16.2;
        string studentName = "Lenny Dermond";

        public double Average()
        {
            // TODO: Determine average of exam score and lab score
            double average = 0;

            // Please dont change the code below (automatic unit tests)
            return average;
        }

        public double Total()
        {
            // TODO: Determine total score if exam counts for 40% and lab for 60%
            double total = 0;

            // Please dont change the code below (automatic unit tests)
            return total;
        }

        public void PrintToTerminal()
        {
            Console.WriteLine(studentName + ":");
            Console.WriteLine("\tExam Score: " + examScore + "/20");
            Console.WriteLine("\tLAB Score: " + labScore + "/20");
            Console.WriteLine("\tAverage Score: " + Average());
            Console.WriteLine("\tTotal Score: " + Total());
        }
    }
}
