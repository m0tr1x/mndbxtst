using mndbxtst.Models;

namespace mndbxtst;

public class Square
{
    
    // Статик, чтобы не вызывать конструктор, но по хорошему его тут не должно быть
    public static double CalculateArea(params double[] lengths)
    {
        IFigure figure = null;
        //Если длина это одна цифра, то это круг
        if (lengths.Length == 1)
        {
            figure = new Circle(lengths[0]);
        }

        //Если длина это две цифры, то это прямоугольник
        if (lengths.Length == 2)
        {
            figure = new Rectangle(lengths[0], lengths[1]);
        }
        //Если длина это три цифры, то это треугольник
        if (lengths.Length == 3)
        {
             figure = new Triangle(lengths[0], lengths[1], lengths[2]);
        }
        if (lengths.Length >3 )throw new Exception("Такой фигуры не существует");
        return figure.GetArea();
    }
}