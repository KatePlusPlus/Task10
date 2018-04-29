using Task10.DAL;
using Task10.Entities;

namespace Task10.BLL
{
    public class RectangleLogic
    {
        private RectangleDAO rectangleDao;

        public RectangleLogic()
        {
            this.rectangleDao = new RectangleDAO();
        }

        public override string ToString()
        {
            return this.rectangleDao.ToString();
        }

        public bool IsSquare()
        {
            return this.rectangleDao.IsSquare();
        }

        public int GetPerimeter(Rectangle value)
        {
            return 2 * (value.A + value.B);
        }

        public int GetArea(Rectangle value)
        {
            return value.A * value.B;
        }

        public int GetA()
        {
            return this.rectangleDao.GetA();
        }

        public int GetB()
        {
            return this.rectangleDao.GetB();
        }

        public void SetA(int value)
        {
            this.rectangleDao.SetA(value);
        }

        public void SetB(int value)
        {
            this.rectangleDao.SetB(value);
        }

        public Rectangle PlusPlus()
        {
            return this.rectangleDao.PlusPlus();
        }

        public Rectangle MinusMinus()
        {
            return this.rectangleDao.MinusMinus();
        }

        public Rectangle Multiply(int n)
        {
            return this.rectangleDao.Multiply(n);
        }
    }
}
