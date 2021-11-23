using FigureAreaCounter.Figures;
using NUnit.Framework;
using System;

namespace AreaCounterTests
{
    public class FigureTests
    {
        private IAreaCountable _circle;
        private IAreaCountable _triangle;

        [SetUp]
        public void Setup()
        {
            _circle = new Circle(1);
            _triangle = new Triangle(3, 4, 5);
        }

        [Test]
        public void FigureAreaIsCountedCorrectlyTest()
        {
            Assert.AreEqual(Math.PI, _circle.CountArea(), 0);
            Assert.AreEqual(6, _triangle.CountArea(), 0);
        }
    }
}