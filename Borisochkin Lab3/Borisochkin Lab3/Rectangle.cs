using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borisochkin_Lab3
{
    /// <summary> 
    /// Класс прямоугольник
    /// </summary>
    class Rectangle : Figure, IPrint
    {
        /// <summary>
        /// Высота
        /// </summary>
       public double height { get; set;}

        /// <summary>
        /// Ширина
        /// </summary>
       public double width { get; set;}

        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="rectheight">Высота</param>
        ///  <param name="rectwidth">Ширина</param>
        public Rectangle(double rectheight, double rectwidth)
        {
            this.height = rectheight;
            this.width = rectwidth;
            this.Type = "Прямоугольник";
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        public override double Area()
        {
            double Result = this.width * this.height;
            return Result;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
