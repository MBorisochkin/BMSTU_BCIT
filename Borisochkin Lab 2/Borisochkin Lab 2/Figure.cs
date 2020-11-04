using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borisochkin_Lab_2
{
    /// <summary> 
    /// Класс фигура 
    /// </summary>
    abstract class Figure
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
    }
}
