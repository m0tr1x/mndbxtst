namespace mndbxtst.Models;


/// <summary>
/// Пример расширения функциональности для фигур
/// </summary>
public class Rectangle : IFigure
{
    private double Width;
    private double Height;

    public Rectangle(double width, double height)
    {
        if(width <= 0 || height <= 0) throw new ArgumentException("Высота и ширина должны быть больше нуля");
        Width = width;
        Height = height;
    }
    public double GetArea()
    {
        return Width * Height;
    }
}