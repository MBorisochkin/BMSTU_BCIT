using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Delegates
{
    /// <summary>
    /// Делегат умножить/разделить целое на целое
    /// </summary>
    delegate double MultiplyDivide(int p1, int p2);

    class Program
    {
        /// <summary>
        /// Метод умножить, соответствующий данному делегату
        /// </summary>
        static double Multiply(int x, int y)
        {
            double res = x * y;
            return res;
        }

        /// <summary>
        /// Метод разделить, соответствующий данному делегату
        /// </summary>
        static double Divide(int x, int y)
        {
            double res = (double)x / (double)y;
            return res;
        }

        /// <summary>
        /// Метод с параметром-делегатом
        /// </summary>
        static void MultiplyDivideMethod(int x, int y, MultiplyDivide mdparam)
        {
            double res = mdparam(x, y);
            Console.WriteLine($"{res.ToString()}");
        }

        /// <summary>
        /// Метод с обощённым делегатом
        /// </summary>
        static void MultiplyDivideMethodFunc(int x, int y, Func<int,int, double> fparam)
        {
            double res = fparam(x, y);
            Console.WriteLine($"{res.ToString()}");
        }

        static void Main(string[] args)
        {
            int a, b;

            // Ввод данных
            Console.WriteLine("Введите целое a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            // Вызов метода с параметром-делегатом
            Console.WriteLine("Вызов метода, примающий метод, с делегатом в параметре:");
            MultiplyDivideMethod(a, b, Multiply);
            MultiplyDivideMethod(a, b, Divide);

            // Вызов метода с параметром-делегатом с помощью лямбда-выражения
            Console.WriteLine("Вызов метода, примающий лямбда-выражение:");
            MultiplyDivideMethod(a, b, (x, y) => x * y);
            MultiplyDivideMethod(a, b, (x,y) => x/y);

            // Вызов метода с обощённым делегатом
            Console.WriteLine("Вызов метода, примающий обощёный делегат:");
            MultiplyDivideMethodFunc(a, b, Multiply);
            MultiplyDivideMethodFunc(a, b, Divide);

            Console.ReadLine();
        }
    }
}
