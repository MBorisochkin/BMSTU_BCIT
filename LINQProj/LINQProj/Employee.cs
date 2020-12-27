using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProj
{
    /// <summary>
    /// Класс "Сотрудник"
    /// </summary>
    class Employee
    {
        /// <summary>
        /// ID сотрудника
        /// </summary>
        public int employee_id;

        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        public string employee_surname;

        /// <summary>
        /// ID отдела
        /// </summary>
        public int department_id;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Employee(int ei, string esn, int di)
        {
            this.employee_id = ei;
            this.employee_surname = esn;
            this.department_id = di;
        }

        /// <summary>
        /// Приведение к строке
        /// </summary>
        public override string ToString()
        {
            return "ID сотрудника: " + this.employee_id.ToString() + "; Фамилия сотрудника: " + this.employee_surname + "; ID отдела:" + this.department_id.ToString();
        }
    }
}
