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
    public void IfTriangleIsRight_ShouldReturnIsRightTrue(double side1, double side2, double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        var result = TriangleCalculator.TriangleCalculator.TryCalculate(triangle, out var calculations);
        Assert.IsTrue(result);
        Assert.IsTrue(calculations.IsRight);
    }

    [TestCase(3, 4, 6)]
    [TestCase(4, 4, 5.6562)]
    public void IfTriangleIsNotRight_ShouldReturnIsRightFalse(double side1, double side2, double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        var result = TriangleCalculator.TriangleCalculator.TryCalculate(triangle, out var calculations);
        Assert.IsTrue(result);
        Assert.IsFalse(calculations.IsRight);
    }

    [TestCase(3, 4, 4)]
    [TestCase(10, 10, 4)]
    [TestCase(4.456, 4.456, 6.727252831855)]
    public void IfTriangleIsIsosceles_ShouldReturnIsIsoscelesTrue(double side1, double side2, double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        var result = TriangleCalculator.TriangleCalculator.TryCalculate(triangle, out var calculations);
        Assert.IsTrue(result);
        Assert.IsTrue(calculations.IsIsosceles);
    }

    [TestCase(5, 4, 8)]
    [TestCase(10, 7, 4)]
    [TestCase(4.456, 4.457, 6.727252831855)]
    public void IfTriangleIsNotIsosceles_ShouldReturnIsIsoscelesFalse(double side1, double side2, double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        var result = TriangleCalculator.TriangleCalculator.TryCalculate(triangle, out var calculations);
        Assert.IsTrue(result);
        Assert.IsFalse(calculations.IsIsosceles);
    }

    [TestCase(3, 4, 4.5)]
    [TestCase(6, 6, 6)]
    [TestCase(4.456, 4.456, 5.727252831855)]
    public void IfTriangleIsAcute_ShouldReturnIsAcuteTrue(double side1, double side2, double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        var result = TriangleCalculator.TriangleCalculator.TryCalculate(triangle, out var calculations);
        Assert.IsTrue(result);
        Assert.IsTrue(calculations.IsAcute);
    }

    [TestCase(5, 5, 9.5)]
    [TestCase(100000, 100000, 150000)]
    [TestCase(4.456, 4.456, 7.727252831855)]
    public void IfTriangleIsNotAcute_ShouldReturnIsAcuteFalse(double side1, double side2, double side3)
    {
        var triangle = new Triangle(side1, side2, side3);
        var result = TriangleCalculator.TriangleCalculator.TryCalculate(triangle, out var calculations);
        Assert.IsTrue(result);
        Assert.IsFalse(calculations.IsAcute);
    }
}