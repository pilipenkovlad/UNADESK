namespace TriangleCalculator.Models;

/// <summary>
/// Модель ответа.
/// nullable bool на случай, если в дальнейшем понадобятся не все поля (напрмер, вычисление поля потенциально тяжелое)
/// </summary>
public class TrianglesCalculations
{
    public AngleType Angle { get; set; }
}