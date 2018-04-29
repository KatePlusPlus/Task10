using System;

namespace Task10.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание прямоугольника");
            PLLogic.SetA();
            PLLogic.SetB();
            Console.WriteLine();

            Console.WriteLine("Выберите действие");
            Console.WriteLine("1. Вывод прямоугольника");
            Console.WriteLine("2. Проверка на квадрат");
            Console.WriteLine("3. Вычисление периметра");
            Console.WriteLine("4. Вычисление площади");
            Console.WriteLine("5. Вывод ширины");
            Console.WriteLine("6. Вывод высоты");
            Console.WriteLine("7. Установка ширины");
            Console.WriteLine("8. Установка высоты");
            Console.WriteLine("9. Оператор ++");
            Console.WriteLine("10. Оператор --");
            Console.WriteLine("11. Умножение на скаляр");

            while (true)
            {
                Console.WriteLine("Введите действие");
                var action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        Console.WriteLine("Вывод прямоугольника");
                        PLLogic.Print();
                        break;
                    case "2":
                        Console.WriteLine("Проверка на квадрат");
                        PLLogic.IsSquare();
                        break;
                    case "3":
                        Console.WriteLine("Вычисление периметра");
                        PLLogic.GetPerimeter();
                        break;
                    case "4":
                        Console.WriteLine("Вычисление площади");
                        PLLogic.GetArea();
                        break;
                    case "5":
                        Console.WriteLine("Вывод ширины");
                        PLLogic.GetA();
                        break;
                    case "6":
                        Console.WriteLine("Вывод высоты");
                        PLLogic.GetB();
                        break;
                    case "7":
                        Console.WriteLine("Установка ширины");
                        PLLogic.SetA();
                        break;
                    case "8":
                        Console.WriteLine("Установка высоты");
                        PLLogic.SetB();
                        break;
                    case "9":
                        Console.WriteLine("Оператор ++");
                        PLLogic.PlusPlus();
                        break;
                    case "10":
                        Console.WriteLine("Оператор --");
                        PLLogic.MinusMinus();
                        break;
                    case "11":
                        Console.WriteLine("Умножение на скаляр");
                        PLLogic.Multiply();
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
