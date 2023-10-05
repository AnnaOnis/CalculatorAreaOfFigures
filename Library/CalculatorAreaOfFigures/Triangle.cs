namespace CalculatorAreaOfFigures
{
    public class Triangle : IFigure
    {
        public double sideA { get; init; }
        public double sideB { get; init; }
        public double sideC { get; init; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a), message: "Длина стороны должна быть больше нуля.");
            if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b), message: "Длина стороны должна быть больше нуля.");
            if (c <= 0) throw new ArgumentOutOfRangeException(nameof(c), message: "Длина стороны должна быть больше нуля.");
            if (a > b + c || b > a + c || c > a + b)
                throw new InvalidOperationException(message: "Такого треугольника не существует. Одна из сторон больше суммы двух других.");

            sideA = a;
            sideB = b; 
            sideC = c;
        }

        public double CalculateArea()
        {
            var p = (sideA + sideB + sideC) / 2;
            var area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            return Math.Round(area, 2);
        }

        public bool IsRectangular()
        {
            bool isRectangular = Math.Pow(sideA, 2) == Math.Pow(sideC, 2) + Math.Pow(sideB, 2) ||
                   Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2) ||
                   Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2);

            return isRectangular;
        }
    }
}