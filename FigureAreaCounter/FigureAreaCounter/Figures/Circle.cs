using System;

namespace FigureAreaCounter.Figures
{
    public class Circle : IAreaCountable
    {
        private double _radius;
        public double CountArea()
        {
            return Math.PI * _radius * _radius;
        }

        public Circle(double radius)
        {

            _radius = radius;
        }
    }
}
