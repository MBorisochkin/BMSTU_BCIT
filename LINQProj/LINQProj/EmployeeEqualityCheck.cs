using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProj
{
    class EmployeeEqualityCheck : IEqualityComparer<Employee>
    {
        public bool Equals(Employee e1, Employee e2)
        {
            if (e1.employee_id == e2.employee_id && e1.employee_surname == e2.employee_surname && e1.department_id == e2.department_id)
                return true;
            else
                return false;
        }

        public int GetHashCode(Employee obj)
        {
            return obj.employee_id;
        }
    }
}
