using ConsoleApp1;

namespace UnitTests
{
    // assume it is sqaure
    public class Rectangle : IShape
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle()
        {
            A = 1;
            B = 1;
        }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public double CalculateShapeArea()
        {
            return A * B;
        }
    }
}