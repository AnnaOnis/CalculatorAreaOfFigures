
namespace CalculatorAreaOfFigures
{
    public class Square : IFigure
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }
        public double SideD { get; init; }
        public double Area => CalculateArea();

        public Square(double value) 
        {
            if(!double.IsNormal(value) || value <= 0) throw new ArgumentOutOfRangeException(nameof(value), message: "Длина стороны должна быть больше нуля.");

            SideA = SideB = SideC = SideD = value;

            if (double.IsInfinity(Area)) throw new ArgumentOutOfRangeException(nameof(Area), message: "Area is infinity");
        }
        private double CalculateArea()
        {
            var area = Math.Pow(SideA, 2);
            return area;
        }
    }
}
