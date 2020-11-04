using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borisochkin_Lab3
{
    /// <summary> 
    /// Класс фигура 
    /// </summary>
    abstract class Figure: IComparable
    {
        ///<summary>
        ///Тип фигуры 
        ///</summary>
        public string Type { get; protected set;}

        ///<summary>
        ///Вычисление площади
        ///</summary>
        public abstract double Area();

        ///<summary>
        ///Приведение к строке
        ///</summary>
        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }

        /// <summary>
        /// Сравнение элементов (для сортировки)
        /// </summary>
        public int CompareTo(object obj)
        {
            Figure p = (Figure)obj;

            if (this.Area() < p.Area())
                return -1;
            else if (this.Area() == p.Area())
                return 0;
            else
                return 1;
        }
    }
}
