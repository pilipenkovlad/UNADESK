namespace TriangleCalculator.Tools;

internal class PifagorComparer
{
    public static int Compare(double[] sides)
    {
        Array.Sort(sides);
        var sqrtSquareSum = Math.Sqrt(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
        var isRight = Math.Abs(sides[2] - sqrtSquareSum) < Constants.Constants.Delta;

        if (isRight)
        {
            return 0;
        }

        return sqrtSquareSum > sides[2] ? -1 : 1;
    }
}