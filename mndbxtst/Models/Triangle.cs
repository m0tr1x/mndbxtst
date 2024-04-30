namespace mndbxtst.Models;

public class Triangle : IFigure
{
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }
    
    private bool IsRightTriangle { get; }
    

    public Triangle(double sideA, double sideB, double sideC)
    {
        // Проверяем, что все стороны больше 0
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)  throw new ArgumentException("Все стороны должны быть больше 0");
       // Забавно, но у Math.Max нет перегрузки для трех чисел, поэтому костылим
        if(!CheckIsTriangle(sideA, sideB, sideC)) throw new ArgumentException("Треугольник не существует");
        
        SideC = Math.Max(sideA, Math.Max(sideB, sideC)); // самая длинная сторона
        SideA = Math.Min(sideA, Math.Min(sideB, sideC)); // самая короткая сторона
        SideB = sideA+sideB+sideC-SideC-SideA; // Последняя сторона
        
        IsRightTriangle = Math.Pow(SideC,2) == Math.Pow(SideA,2) + Math.Pow(SideB,2);
        
    }

    public double GetArea()
    {
        if (IsRightTriangle)
        { 
            return SideA * SideB / 2;
        }
        else
        {
            //Если треугольник не прямоугольный, то по формуле Герона
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
    }


    /// <summary>
    /// Функция проверяет, существует ли такой треугольник
    /// </summary>
    /// <param name="sideA"></param>
    /// <param name="sideB"></param>
    /// <param name="sideC"></param>
    /// <returns></returns>
    private bool CheckIsTriangle(double sideA, double sideB, double sideC)
    {
        return (sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideC + sideA > sideB);
        // Можно было сделать через Math.Max, но для трех чисел нет перегрузки, поэтому проще так
    }
}