using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borisochkin_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(3, 2);
            Square square = new Square(6);
            Circle circle = new Circle(2);

            // Коллекция класса ArrayList
            ArrayList f1 = new ArrayList();

            // Добавление элементов
            f1.Add(rect);
            f1.Add(square);
            f1.Add(circle);

            // Вывод коллекции до сортировки
            Console.WriteLine("ArrayList: \n");
            Console.WriteLine("До сортировки:");
            foreach (var i in f1)
                Console.WriteLine(i);

            // Сортировка и вывод коллекции после сортировки
            Console.WriteLine("\nПосле сортировки:");
            f1.Sort();
            foreach (var i in f1)
                Console.WriteLine(i);

            // Коллекция класса List<Figure>
            List<Figure> f2 = new List<Figure>();

            // Добавление элементов
            f2.Add(square);
            f2.Add(circle);
            f2.Add(rect);

            // Вывод коллекции до сортировки
            Console.WriteLine("\nList<Figure>:");
            Console.WriteLine("\nДо сортировки:");
            foreach (var i in f2)
                Console.WriteLine(i);

            // Сортировка и вывод коллекции после сортировки
            Console.WriteLine("\nПосле сортировки:");
            f2.Sort();
            foreach (var i in f2)
                Console.WriteLine(i);

            // Матрица
            Console.WriteLine("\nМатрица:");
            SparseMatrix<Figure> fmatrix = new SparseMatrix<Figure>(3, 3, 3, new FigureMatrixCheckEmpty());
            fmatrix[0, 0, 0] = rect;
            fmatrix[1, 1, 1] = square;
            fmatrix[2, 2, 2] = circle;
            Console.WriteLine(fmatrix.ToString());

            //Стек
            Console.WriteLine("\nСтек:");
            SimpleStack<Figure> fstack = new SimpleStack<Figure>();

            // Добавление элементов в стек
            fstack.Push(rect);
            fstack.Push(square);
            fstack.Push(circle);

            // Чтение из стека и вывод элементов
            while(fstack.Count > 0)
            {
                Figure f = fstack.Pop();
                Console.WriteLine(f);
            }

            Console.ReadLine();
        }
    }
}
