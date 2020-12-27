using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProj
{
    class DepartmentEqualityCheck : IEqualityComparer<Department>
    {
        public bool Equals(Department d1, Department d2)
        {
        if (d1.department_id == d2.department_id && d1.department_name == d2.department_name)
            return true;
        else
            return false;
        }

        public int GetHashCode(Department obj)
        {
            return obj.department_id;
        }
    }
}
