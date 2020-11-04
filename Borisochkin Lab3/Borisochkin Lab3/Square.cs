using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borisochkin_Lab3
{
    /// <summary> 
    /// Класс квадрат 
    /// </summary>
    class Square : Rectangle, IPrint
    {
        /// <summary>
        /// Основной конструктор
        /// </summary>
        /// <param name="size">Длина стороны квадрата</param>
        public Square(double size): base(size,size)
        {
            this.Type = "Квадрат";
        }
    }
}
