using System;
namespace HW1
{
    class Program
    {
        static void Main()
        {
            double x1, x2, y1, y2;
            Console.Write("Введите x1:");
            if(double.TryParse(Console.ReadLine(),out x1))
            {

            }
            else
            {
                Console.WriteLine("Неправильный диапазон ввода");
                return;
            }
            Console.Write("Введите x2:");
            if (double.TryParse(Console.ReadLine(),out x2))
            {

            }
            else
            {
                Console.WriteLine("Неправильный диапазон ввода");
                return;
            }
            Console.Write("Введите y1:");
            if (double.TryParse(Console.ReadLine(),out y1))
            {

            }
            else
            {
                Console.WriteLine("Неправильный диапазон ввода");
                return;
            }
            Console.Write("Введите y2:");
            if (double.TryParse(Console.ReadLine(), out y2))
            {

            }
            else
            {
                Console.WriteLine("Неправильный диапазон ввода");
                return;
            }
            double f = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между двумя точками = {f:0.000} ");

        }
    }
}