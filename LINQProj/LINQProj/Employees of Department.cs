using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProj
{
    class Employees_of_Department
    {
        public int employee_id;

        public int department_id;

        public Employees_of_Department(int eid, int did)
        {
            this.employee_id = eid;
            this.department_id = did;
        }
    }
}
