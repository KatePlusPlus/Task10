using System;
using Task10.BLL;
using Task10.Entities;

namespace Task10.PL
{
    public class PLLogic
    {
        private static RectangleLogic rectangleLogic = new RectangleLogic();

        public static void Print()
        {
            Console.WriteLine(rectangleLogic);
        }

        public static void IsSquare()
        {
            Console.WriteLine(rectangleLogic.IsSquare());
        }

        public static void GetPerimeter()
        { 
            var rectangle = new Rectangle(rectangleLogic.GetA(), rectangleLogic.GetB());

            Console.WriteLine("Периметр: " + rectangleLogic.GetPerimeter(rectangle));
        }

        public static void GetArea()
        {
            var rectangle = new Rectangle(rectangleLogic.GetA(), rectangleLogic.GetB());

            Console.WriteLine("Площадь: " + rectangleLogic.GetArea(rectangle));
        }

        public static void GetA()
        {
            Console.WriteLine("Ширина: " + rectangleLogic.GetA());
        }

        public static void GetB()
        {
            Console.WriteLine("Высота: " + rectangleLogic.GetB());
        }

        public static void SetA()
        {
            Console.WriteLine("Введите ширину");
            var width = int.Parse(Console.ReadLine());

            rectangleLogic.SetA(width);
        }

        public static void SetB()
        {
            Console.WriteLine("Введите высоту");
            var height = int.Parse(Console.ReadLine());

            rectangleLogic.SetB(height);
        }

        public static void PlusPlus()
        {
            Console.WriteLine(rectangleLogic.PlusPlus());
        }

        public static void MinusMinus()
        {
            Console.WriteLine(rectangleLogic.MinusMinus());
        }

        public static void Multiply()
        {
            Console.WriteLine("Введите cкаляр");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(rectangleLogic.Multiply(n));
        }
    }
}
