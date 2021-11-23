using System;

namespace FigureAreaCounter.Figures
{
    public class Triangle : IRightCheckable
    {
        private double _a;
        private double _b;
        private double _c;

        public double CountArea()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRightFigure()
        {
            var sqrA = _a * _a;
            var sqrB = _b * _b;
            var sqrC = _c * _c;

            return sqrA == sqrB + sqrC 
                || sqrB == sqrA + sqrC
                || sqrC == sqrA + sqrB;
        }

        private bool IsTriangleExisting(double a, double b, double c)
        {
            return a < b + c 
                && b < a + c 
                && c < a + b;
        }

        public Triangle(double a, double b, double c)
        {
            if (!IsTriangleExisting(a, b, c))
            {
                throw new TriangleDoesNotExistException($"Triangle with a = {a}, b = {b}, c = {c} does not exist");
            }

            _a = a;
            _b = b;
            _c = c;
        }
    }
}
