using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borisochkin_Lab_2
{
    /// <summary> 
    /// Класс круг
    /// </summary>
    class Circle : Figure, IPrint
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double radius { get; set; }

        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="r">Радиус</param>
        public Circle(double r)
        {
            this.radius = r;
            this.Type = "Круг";
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        public override double Area()
        {
            double Result = Math.PI * this.radius * this.radius;
            return Result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
