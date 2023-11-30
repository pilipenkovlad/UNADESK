using TriangleCalculator.Models;
using TriangleCalculator.Validatiors;

namespace TriangleCalculator;

public class TriangleCalculator
{
    public static bool TryCalculate(Triangle triangle, out TrianglesCalculations calculations)
    {
        calculations = new TrianglesCalculations();

        if (!TriangleValidator.IsValid(triangle.Sides))
        {
            return false;
        }

        Array.Sort(triangle.Sides);

        calculations.IsIsosceles = IsIsosceles(triangle.Sides);

        var pifagorComparison = PifagorComparer(triangle.Sides);
        calculations.IsRight = pifagorComparison == 0;
        calculations.IsAcute = pifagorComparison == -1;

        return true;
    }

    private static bool IsIsosceles(double[] sides)
    {
        return Math.Abs(sides[0] - sides[1]) < Constants.Constants.Delta ||
               Math.Abs(sides[1] - sides[2]) < Constants.Constants.Delta;
    }

    private static int PifagorComparer(double[] sides)
    {
        var sqrtSquareSum = Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
        var isRight = Math.Abs(sides[2] - sqrtSquareSum) < Constants.Constants.Delta;

        if (isRight)
        {
            return 0;
        }

        return sqrtSquareSum > sides[2] ? -1 : 1;
    }
}