using FigureAreaCounter.Figures;
using NUnit.Framework;

namespace AreaCounterTests
{
    public class TriangleTests
    {
        private IAreaCountable _triangle;
        private IRightCheckable _rightTriangle;
        private IRightCheckable _notRightTriangle;

        [SetUp]
        public void Setup()
        {
            _triangle = new Triangle(4, 5, 6);
            _rightTriangle = new Triangle(3, 4, 5);
            _notRightTriangle = new Triangle(6, 7, 8);
        }

        [Test]
        public void TriangleAreaIsCountedCorrectlyTest()
        {
            Assert.AreEqual(9.921567, _triangle.CountArea(), 0.000001);
            Assert.AreEqual(6, _rightTriangle.CountArea(), 0);
        }

        [Test]
        public void RightTriangleIsDefinedCorrectlyTest()
        {
            Assert.IsTrue(_rightTriangle.IsRightFigure());
        }

        [Test]
        public void RightTriangleIsNotDefinedCorrectlyTest()
        {
            Assert.IsFalse(_notRightTriangle.IsRightFigure());
        }

        [Test]
        public void TriangleDoesNotExistTest()
        {
            Assert.Catch<TriangleDoesNotExistException> (() => new Triangle(10, 3, 4));
            Assert.Catch<TriangleDoesNotExistException>(() => new Triangle(1, 2, 6));
            Assert.Catch<TriangleDoesNotExistException>(() => new Triangle(10, 15, 5));
        }
    }
}