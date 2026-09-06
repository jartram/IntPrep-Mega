/*
 =======================================================================================
 CHALLENGE: Total-surface (28-interfaces)
 CHAPTER: Chapter28_Interfaces
 
 DESCRIPTION:
 * # Total Surface
 *
 * Total Surface is a small part of an application build for an architect. The architect in question uses the app to calculate the total surface of a house when he/she visits a home that needs to be remodelled.
 *
 * The problem with the application is that it is not build with good programming practices in mind and is therefore hard to extend with new capabilities.
 *
 * Currently the application allows the user to enter two different room shape dimensions and can then determine the total surface area. Try the application before continuing with the assignment.
 *
 * To get a feel of the problems that arise when extending the application, add a new shape class `Rectangle` to the application that allows a rectangular surface to be added to the listing. Make sure the whole application is operational.
 *
 * While the `Main()` can probable be cleaned up a bit too, that is not the biggest problem of this application. The biggest problem lies within the fact that `AreaListing` is tightly coupled to the shape classes. This can be fixed using a decent interface.
 *
 * Do your best to fix this mess.
 *
 * ## Expected Output
 *
 * ```text
 * ....
 *
 * What shape would you like to create ?
 * 1. Circle
 * 2. Square
 * 0. Exit
 * 2
 * Please enter side of square: 33
 *
 * You current surface listing:
 * <Square> [side = 10]: 100 sq. meters
 * <Square> [side = 6.4]: 40.96000000000001 sq. meters
 * <Square> [side = 33]: 1089 sq. meters
 * <Circle> [radius = 12.2]: 467.59465056030473 sq. meters
 * <Circle> [radius = 2.15]: 14.522012041218819 sq. meters
 * ------------------------------
 * Total Area: 1712.0766626015236 sq. meters
 *
 * What shape would you like to create ?
 * 1. Circle
 * 2. Square
 * 0. Exit
 * 0
 * Thank you for using our app.
 * ```
 
 VALIDATION COMMAND:
 dotnet test tests/CSharpPractical.Tests --filter FullyQualifiedName~CSharpPractical.Tests.Chapter28_Interfaces.TotalSurfaceTest
 =======================================================================================
*/

namespace CSharpPractical.Chapter28_Interfaces.Total_surface
{
  public class Circle
    {
    public Circle(double radius)
    {
      Radius = radius;
    }

    public double GetArea()
    {
      return Math.PI * Radius * Radius;
    }

    private double radius;
    public double Radius
    {
      get { return radius; }
      set { radius = Math.Abs(value); }
    }

    public override string ToString()
    {
      return $"<Circle> [radius = {Radius}]: {GetArea()} sq. meters";
    }
  }
}
