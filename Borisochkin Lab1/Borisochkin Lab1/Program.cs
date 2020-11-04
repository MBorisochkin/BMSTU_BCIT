using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Borisochkin_Lab1
{
    class Program
    {
        /// <summary>
        /// Считывание коэффицента
        /// </summary>
        /// <param name="x">Наименование коэффицента</param>
        /// <returns>Значение коэффицент</returns>
        static double CheckValue(string x)
        {
            bool checker;
            double k;

            if (x == "A")
            {
                checker = double.TryParse(Console.ReadLine(), out k);
                while (checker == false || k == 0)
                {
                    Console.WriteLine("Некорректный коэффицент {0}. Введите его ещё раз", x);
                    checker = double.TryParse(Console.ReadLine(), out k);
                }
            }
            else
            {
                checker = double.TryParse(Console.ReadLine(), out k);
                while (checker == false)
                {
                    Console.WriteLine("Некорректный коэффицент {0}. Введите его ещё раз", x);
                    checker = double.TryParse(Console.ReadLine(), out k);
                }
            }

            return k;
        }

        static void Main(string[] args)
        {
            double a, b, c; // Коэффиценты биквадратного уравнения

            Console.WriteLine("Борисочкин М.И., РТ5-31Б");
            Console.WriteLine();

            /// <summary>
            /// Ввод коэффицентов
            /// </summary>
            // Ввод коэфицента A
            Console.WriteLine("Введите коэффицент A:");
            a = CheckValue("A");
            
            // Ввод коэфицента B
            Console.WriteLine("Введите коэффицент B:");
            b = CheckValue("B");

            // Ввод коэфицента C
            Console.WriteLine("Введите коэффицент C:");
            c = CheckValue("C");

            /// <summary>
            /// Подсчёт и вывод корней
            /// </summary>
            double d = b * b - 4 * a * c; // Дискриминант
            double r1, r2; // Корни уравнения

            if(d < 0) // Случай отсутствия корней
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней нет");
                Console.ResetColor();
            }
            else
            {
                if (d == 0) // Дискриминант равен нулю
                {
                    if((-1 * b / (2 * a)) < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет");
                    }
                    else
                    {
                        r1 = Sqrt(-1 * b / (2 * a));

                        Console.ForegroundColor = ConsoleColor.Green;
                        if(r1 == 0)
                            Console.WriteLine("Корень уравнения: {0}", r1);
                        else
                            Console.WriteLine("Корни уравнения: {0}, {1}", -1*r1, r1);
                    }
                    Console.ResetColor();
                }
                else // Дискриминант больше нуля
                {
                    r1 = (-1 * b + Sqrt(d)) / (2 * a);
                    r2 = (-1 * b - Sqrt(d)) / (2 * a);

                    if(r1 < 0 && r2 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Корней нет");
                    }
                    else if (r1 > 0)
                    {
                        r1 = Sqrt(r1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (r2 < 0)
                            Console.WriteLine("Корни уравнения: {0}, {1}", -1 * r1, r1);
                        else if (r2 == 0)
                            Console.WriteLine("Корни уравнения: {0}, {1}, {2}", -1 * r1, r1, r2);
                        else
                        {
                            r2 = Sqrt(r2);
                            Console.WriteLine("Корни уравнения: {0}, {1}, {2}, {3}", -1 * r1, r1, -1 * r2, r2);
                        }
                    }
                    else if(r2 > 0)
                    {
                        r2 = Sqrt(r2);
                        Console.ForegroundColor = ConsoleColor.Green;
                        if (r1 < 0)
                            Console.WriteLine("Корни уравнения: {0}, {1}", -1 * r2, r2);
                        else if (r1 == 0)
                            Console.WriteLine("Корни уравнения: {0}, {1}, {2}", r1, -1 * r2, r2);
                    }
                    Console.ResetColor();
                }
            }
            Console.ReadLine();
        }
    }
}
