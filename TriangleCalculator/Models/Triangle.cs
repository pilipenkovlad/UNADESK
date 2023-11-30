namespace TriangleCalculator.Models;

/// <summary>
/// Модель запроса, включает три стороны
/// </summary>
/// <param name="Side1"></param>
/// <param name="Side2"></param>
/// <param name="Side3"></param>
public record Triangle(double Side1, double Side2, double Side3)
{
    public readonly double[] Sides = { Side1, Side2, Side3 };
}