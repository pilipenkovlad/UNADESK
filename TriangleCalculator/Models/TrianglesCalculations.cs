namespace TriangleCalculator.Models;

/// <summary>
/// Модель ответа.
/// nullable enum на случай, если треугольник невалидный)
/// </summary>
public record TrianglesCalculations
{
    public AngleType? Angle { get; set; }
}