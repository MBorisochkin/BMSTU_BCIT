using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProj
{
    /// <summary>
    /// Класс "Отдел"
    /// </summary>
    class Department
    {
        /// <summary>
        /// ID отдела
        /// </summary>
        public int department_id;

        /// <summary>
        /// Наименование отдела
        /// </summary>
        public string department_name;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Department(int di, string dn)
        {
            this.department_id = di;
            this.department_name = dn;
        }

        /// <summary>
        /// Приведение к строке
        /// </summary>
        public override string ToString()
        {
            return "ID отдела: " + this.department_id.ToString() + "; Наименование отдела: " + this.department_name;
        }
    }
}
