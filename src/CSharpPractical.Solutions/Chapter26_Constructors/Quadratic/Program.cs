/*
 =======================================================================================
 CHALLENGE: Quadratic (26-constructors)
 CHAPTER: Chapter26_Constructors
 
 DESCRIPTION:
 * ---
 * name: Quadratic
 * description: Solve a quadratic equation
 * details: ./23-defining-custom-classes/quadratic/README.md
 * difficulty: Medium
 * solution: false
 * unitTests: false
 * keywords: classes methods operators
 * solved: false
 * draft: true
 * notes:
 * ---
 *
 * # Things are Complex
 *
 * Create a new class called `QuadraticEquation` that follows the following UML class diagram:
 *
 * ```text
 * #################################
 * # QuadraticEquation
 * #################################
 * # - a: double
 * # - b: double
 * # - c: double
 * #################################
 * # + QuadraticEquation(a: double, b: double, c: double)
 * # + Solve(): QuadraticSolution
 * # + ToString(): string
 * #################################
 * ```
 *
 * The `ToString()` method should return the equation in the following format: `"12.3x^2 + 3x + 15 = 0".
 *
 * The `Solve()` method returns an object of the class `QuadraticSolution` which adheres to the following UML class diagram:
 *
 * ```text
 * #################################
 * # QuadraticSolution
 * #################################
 * # - x1: double
 * # - x2: double
 * #################################
 * # + QuadraticSolution(x1: double, x2: double)
 * # + GetX1(): double
 * # + GetX2(): double
 * # + ToString(): string
 * #################################
 * ```
 *
 * The `ToString()` method should return the solution in the following format: `"x1 = 33, x2 = -23"` if the discriminant is positive, `"x1 = 12, x2 = 12"` if the discriminant is zero or `"x1 = complex, x2 = complex"` if it is a complex solution.
 *
 * Checkout the following wikipedia page on more info on how to solve the equation [https://en.wikipedia.org/wiki/Quadratic_formula](https://en.wikipedia.org/wiki/Quadratic_formula). Some more information about the discriminant can be found here: [https://www.khanacademy.org/math/algebra/x2f8bb11595b61c86:quadratic-functions-equations/x2f8bb11595b61c86:quadratic-formula-a1/a/discriminant-review](https://www.khanacademy.org/math/algebra/x2f8bb11595b61c86:quadratic-functions-equations/x2f8bb11595b61c86:quadratic-formula-a1/a/discriminant-review).
 *
 * Create a demo application and request the necessary information from the user.
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter26_Constructors.Quadratic.UnitTest1
 =======================================================================================
*/

﻿using System;

namespace CSharpPractical.Chapter26_Constructors.Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
