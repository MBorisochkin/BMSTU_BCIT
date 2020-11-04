using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borisochkin_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            // Ввод данных для прямоугольника и его создание
            Console.WriteLine("Введите высоту прямоугольника");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника");
            b = Convert.ToDouble(Console.ReadLine());
            Rectangle rect = new Rectangle(a, b);

            // Ввод данных для квадрата и его создание
            Console.WriteLine("Введите длину стороны квадрата");
            a = Convert.ToDouble(Console.ReadLine());
            Square square = new Square(a);

            // Ввод данных для круга и его создание
            Console.WriteLine("Введите радиус круга");
            a = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(a);

            // Вывод данных
            rect.Print();
            square.Print();
            circle.Print();

            Console.ReadLine();
        }
    }
}
