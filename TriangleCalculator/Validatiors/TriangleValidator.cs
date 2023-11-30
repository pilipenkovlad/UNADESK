namespace TriangleCalculator.Validatiors;

internal static class TriangleValidator
{
    public static bool IsValid(double[] sides)
    {
        if (sides is null || sides.Length != 3)
        {
            return false;
        }

        if (sides.Any(s => s <= 0))
        {
            return false;
        }

        if (sides[2] >= sides[0] + sides[1])
        {
            return false;
        }

        return true;
    }
}