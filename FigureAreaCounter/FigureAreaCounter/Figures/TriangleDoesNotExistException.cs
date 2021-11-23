using System;

namespace FigureAreaCounter.Figures
{
    public class TriangleDoesNotExistException: ArgumentException
    {
        public TriangleDoesNotExistException(string msg) : base(msg) { }

        public TriangleDoesNotExistException() : base() { }
    }
}
