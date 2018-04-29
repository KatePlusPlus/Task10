using Task10.Entities;

namespace Task10.DAL
{
    public class RectangleDAO
    {
        private Rectangle rectangle;

        public RectangleDAO()
        {
            this.rectangle = new Rectangle();
        }

        public override string ToString()
        {
            return this.rectangle.ToString();
        }

        public bool IsSquare()
        {
            return this.rectangle.IsSquare;
        }

        public int GetA()
        {
            return this.rectangle[0];
        }

        public int GetB()
        {
            return this.rectangle[1];
        }

        public void SetA(int value)
        {
            this.rectangle[0] = value;
        }

        public void SetB(int value)
        {
            this.rectangle[1] = value;
        }

        public Rectangle PlusPlus()
        {
            return rectangle++;
        }

        public Rectangle MinusMinus()
        {
            return rectangle--;
        }

        public Rectangle Multiply(int n)
        {
            return rectangle *= n;
        }
    }
}
