namespace CalculatorAreaOfFigures
{
    public class Triangle : IFigure
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }
        public double Area  => CalculateArea();

        public Triangle(double a, double b, double c)
        {
            if (!double.IsNormal(a) || a <= 0) throw new ArgumentOutOfRangeException(nameof(a), message: "Длина стороны должна быть больше нуля.");
            if (!double.IsNormal(b) || b <= 0) throw new ArgumentOutOfRangeException(nameof(b), message: "Длина стороны должна быть больше нуля.");
            if (!double.IsNormal(c) || c <= 0) throw new ArgumentOutOfRangeException(nameof(c), message: "Длина стороны должна быть больше нуля.");

            if (a > b + c)throw new ArgumentException(message: $"Такого треугольника не существует. Cторона {nameof(a)} больше суммы двух других.");
            if (b > a + c) throw new ArgumentException(message: $"Такого треугольника не существует. Cторона {nameof(b)} больше суммы двух других.");
            if (c > a + b) throw new ArgumentException(message: $"Такого треугольника не существует. Cторона {nameof(c)} больше суммы двух других.");

            SideA = a;
            SideB = b; 
            SideC = c;

            if(double.IsInfinity(Area)) throw new ArgumentException(message: $"{nameof(Area)} isInfinity");
        }

        public double CalculateArea()
        {
            var p = (SideA + SideB + SideC) / 2;
            var area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return Math.Round(area, 2);
        }

        public bool IsRectangular()
        {
            bool isRectangular = Math.Pow(SideA, 2) == Math.Pow(SideC, 2) + Math.Pow(SideB, 2) ||
                   Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2) ||
                   Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2);

            return isRectangular;
        }
    }
}