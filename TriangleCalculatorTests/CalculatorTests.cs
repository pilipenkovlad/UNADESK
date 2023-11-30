using NUnit.Framework;
using TriangleCalculator.Models;

namespace TriangleCalculatorTests;

public class CalculatorTests
{
    [TestCase(4, 5, 10)]
    [TestCase(4, 5, 9)]
    [TestCase(0, 5, 3)]
    [TestCase(4, 5, -3)]
    public void IfTriangleIsNotValid_ShouldReturnFalse(double side1, double side2, double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        var result = TriangleCalculator.TriangleCalculator.TryCalculate(triangle, out _);
        Assert.IsFalse(result);
    }

    [TestCase(3, 4, 5)]
    [TestCase(4, 4, 5.656854249492)]
    [TestCase(3.456, 4.567, 5.727252831855)]
    public void IfTriangleIsRight_ShouldReturnAngleRight(double side1, double side2, double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        var result = TriangleCalculator.TriangleCalculator.TryCalculate(triangle, out var calculations);
        Assert.IsTrue(result);
        Assert.AreEqual(AngleType.Right, calculations.Angle);
    }

    [TestCase(3, 4, 4.5)]
    [TestCase(6, 6, 6)]
    [TestCase(4.456, 4.456, 5.727252831855)]
    public void IfTriangleIsAcute_ShouldReturnAngelAcute(double side1, double side2, double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        var result = TriangleCalculator.TriangleCalculator.TryCalculate(triangle, out var calculations);
        Assert.IsTrue(result);
        Assert.AreEqual(AngleType.Acute, calculations.Angle);
    }

    [TestCase(2, 2, 3)]
    [TestCase(1, 5, 5.5)]
    [TestCase(4.456, 4.456, 7.727252831855)]
    public void IfTriangleIsObtuse_ShouldReturnAngelObtuse(double side1, double side2, double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        var result = TriangleCalculator.TriangleCalculator.TryCalculate(triangle, out var calculations);
        Assert.IsTrue(result);
        Assert.AreEqual(AngleType.Obtuse, calculations.Angle);
    }
}