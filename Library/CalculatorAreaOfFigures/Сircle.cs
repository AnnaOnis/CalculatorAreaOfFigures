

namespace CalculatorAreaOfFigures
{
    public class Сircle : IFigure
    {
        public double Radius { get; init; }
        public double Area => CalculateArea();

        public Сircle(double r)
        {
            if (!double.IsNormal(r) || r <= 0) { throw new ArgumentOutOfRangeException(nameof(r), message: "Длина радиуса должна быть больше нуля"); }
            Radius = r;

            if (double.IsInfinity(Area)) throw new ArgumentOutOfRangeException(nameof(Area), message: "Area is infinity");
        }


        private double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return Math.Round(area, 2);
        }
    }
}
