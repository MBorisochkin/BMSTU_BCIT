using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Reflection
{
    class Flat : IComparable
    {
        // Конструкторы
        public Flat() { }
        public Flat(string adress) { this.adress = adress; }
        public Flat(string adress, double meters, int rooms)
        {
            this.adress = adress;
            this.meters = meters;
            this.rooms = rooms;
        }

        // Свойства
        [NewAttribute("Адрес")]
        public string adress { get; set; }

        public double meters { get; set; }

        [NewAttribute(Description = "Количество комнат")]
        public int rooms { get; set; }

        // Метод
        public double CountPrice(int r,double m)
        {
            double totalprice = (double)r * 1000000 + m * 100000;

            return totalprice;
        }

        /// <summary>
        /// Реализация интерфейса IComparable
        /// </summary>
        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
