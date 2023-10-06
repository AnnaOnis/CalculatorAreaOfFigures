using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAreaOfFigures
{
    public class Сircle : IFigure
    {
        public double radius { get; init; }
        public double Area => CalculateArea();

        public Сircle(double r)
        {
            if (!double.IsNormal(r) || r <= 0) { throw new ArgumentOutOfRangeException(nameof(r), message: "Длина радиуса должна быть больше нуля"); }
            radius = r;

            if (double.IsInfinity(Area)) throw new ArgumentOutOfRangeException(nameof(Area), message: "Area is infinity");
        }


        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return Math.Round(area, 2);
        }
    }
}
