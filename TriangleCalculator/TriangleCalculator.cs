using TriangleCalculator.Models;
using TriangleCalculator.Tools;
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

        var pifagorComparison = PifagorComparer.Compare(triangle.Sides);

        switch (pifagorComparison)
        {
            case 0:
                calculations.Angle = AngleType.Right;
                break;
            case -1:
                calculations.Angle = AngleType.Acute;
                break;
            case 1:
                calculations.Angle = AngleType.Obtuse;
                break;
        }

        return true;
    }
}