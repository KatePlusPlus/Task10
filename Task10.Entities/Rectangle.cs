namespace Task10.Entities
{
    public class Rectangle
    {
        public int A { get; set; }
        public int B { get; set; }

        public Rectangle(int width, int height)
        {
            A = width;
            B = height;
        }

        public Rectangle()
        {
            A = 0;
            B = 0;
        }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return A;
                else if (index == 1)
                    return B;
                else
                {
                    throw new System.Exception("Неправильное значение");
                }
            }
            set
            {
                if (index == 0)
                    A = value;
                else if (index == 1)
                    B = value;
                else
                    throw new System.Exception("Неправильное значение");
            }
        }

        public static Rectangle operator ++(Rectangle r)
        {
            r.A++;
            r.B++;

            return r;
        }

        public static Rectangle operator --(Rectangle r)
        {
            try
            {
                r.A--;
                r.B--;

                if (r.A < 0 || r.B < 0)
                    throw new System.ArithmeticException();
            }
            catch (System.ArithmeticException)
            {
                r.A++;
                r.B++;
            }

            return r;
        }

        public static bool operator true(Rectangle r)
        {
            return r.A == r.B;
        }

        public static bool operator false(Rectangle r)
        {
            return r.A != r.B;
        }

        public static Rectangle operator *(Rectangle r, int n)
        {
            r.A *= n;
            r.B *= n;

            return r;
        }

        public bool IsSquare
        {
            get
            {
                return this.A == this.B;
            }
        }

        public override string ToString()
        {
            return $"{A} {B}";
        }

        public override bool Equals(object obj)
        {
            var rectangle = obj as Rectangle;

            if (rectangle == null)
                return false;

            return this.A == rectangle.A && this.B == rectangle.B;
        }
    }
}
