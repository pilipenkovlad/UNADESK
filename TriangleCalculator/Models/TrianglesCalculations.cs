namespace TriangleCalculator.Models;

/// <summary>
/// Модель ответа.
/// nullable bool на случай, если в дальнейшем понадобятся не все поля (напрмер, вычисление поля потенциально тяжелое)
/// </summary>
public class TrianglesCalculations
{
    public bool? IsRight { get; set; }
    public bool? IsAcute { get; set; }
    public bool? IsIsosceles { get; set; }
}