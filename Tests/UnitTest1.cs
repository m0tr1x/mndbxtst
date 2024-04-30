using mndbxtst;
using mndbxtst.Models;

namespace Tests;

public class UnitTest1
{
    [Fact]
    public void Circle_Area_Is_Correct()
    {
        // Arrange
        double radius = 10;
        // Act
        double area = Square.CalculateArea(radius);
        
        // Assert
        Assert.Equal(314.1592653589793, area);
    }

    [Fact]
    public void Real_Square_Area_Is_Correct()
    {
        // Arrange
        double width = 10;
        double height = 5;
        
        // Act
        double area = Square.CalculateArea(width, height);
        
        // Assert
        Assert.Equal(50, area);
    }

    [Fact]
    public void Triangle_Area_Is_Correct()
    {
        // Arrange
        double a = 10;
        double b = 6;
        double c = 8;

        // Act

        double area = Square.CalculateArea(a, b, c);

        // Assert
        Assert.Equal(24, area);
    }



}