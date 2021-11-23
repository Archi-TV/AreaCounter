using FigureAreaCounter.Figures;
using NUnit.Framework;
using System;

namespace AreaCounterTests
{
    public class CircleTests
    {
        private IAreaCountable _circle1;
        private IAreaCountable _circle2;

        [SetUp]
        public void Setup()
        {
            _circle1 = new Circle(1);
            _circle2 = new Circle(3);
        }

        [Test]
        public void CircleAreaIsCountedCorrectlyTest()
        {
            Assert.AreEqual(Math.PI, _circle1.CountArea(), 0);
            Assert.AreEqual(Math.PI * 9, _circle2.CountArea(), 0);
        }
    }
}