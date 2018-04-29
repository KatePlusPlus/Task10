using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task10.BLL;
using Task10.Entities;

namespace Task10.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        RectangleLogic rectangleLogic = new RectangleLogic();

        private void Set(int width, int height)
        {
            rectangleLogic.SetA(width);
            rectangleLogic.SetB(height);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Set(2, 3);
            Assert.AreEqual("2 3", rectangleLogic.ToString());
            Set(3, 2);
            Assert.AreEqual("3 2", rectangleLogic.ToString());
        }

        [TestMethod()]
        public void IsSquareTest()
        {
            Set(2, 2);
            Assert.IsTrue(rectangleLogic.IsSquare());
            Set(2, 3);
            Assert.IsFalse(rectangleLogic.IsSquare());
        }

        [TestMethod()]
        public void GetPerimeterTest()
        {
            Assert.AreEqual(8, rectangleLogic.GetPerimeter(new Rectangle(2, 2)));
            Assert.AreEqual(10, rectangleLogic.GetPerimeter(new Rectangle(2, 3)));
        }

        [TestMethod()]
        public void GetAreaTest()
        {
            Assert.AreEqual(4, rectangleLogic.GetArea(new Rectangle(2, 2)));
            Assert.AreEqual(6, rectangleLogic.GetArea(new Rectangle(2, 3)));
        }

        [TestMethod()]
        public void PlusPlusTest()
        {
            Set(2, 2);
            Assert.AreEqual(new Rectangle(3, 3), rectangleLogic.PlusPlus());
            Set(2, 3);
            Assert.AreEqual(new Rectangle(3, 4), rectangleLogic.PlusPlus());
        }

        [TestMethod()]
        public void MinusMinusTest()
        {
            Set(0, 0);
            Assert.AreEqual(new Rectangle(0, 0), rectangleLogic.MinusMinus());
            Set(2, 3);
            Assert.AreEqual(new Rectangle(1, 2), rectangleLogic.MinusMinus());
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Set(0, 0);
            Assert.AreEqual(new Rectangle(0, 0), rectangleLogic.Multiply(0));
            Set(2, 3);
            Assert.AreEqual(new Rectangle(4, 6), rectangleLogic.Multiply(2));
        }
    }
}