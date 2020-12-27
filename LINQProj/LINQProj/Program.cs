using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProj
{
    class Program
    {
        // <summary>
        /// Сотрудники
        /// </summary>
        static List<Employee> employees = new List<Employee>()
        {
           new Employee(1, "Афанасьев", 1),
           new Employee(2, "Демченков", 1),
           new Employee(3, "Борисочкин", 2),
           new Employee(4, "Герасимов", 2),
           new Employee(5, "Чернов", 1),
           new Employee(6, "Рогова", 1),
           new Employee (7, "Аникин", 3),
           new Employee (8, "Азхар", 3),
           new Employee (9, "Алиев", 3)
        };

        // <summary>
        /// Отделы
        /// </summary>
        static List<Department> departments = new List<Department>()
        {
            new Department (2, "Учебный"),
            new Department (1, "Научный"),
            new Department (3, "Административный")
        };

        // <summary>
        /// Сотрудники отдела
        /// </summary>
        static List<Employees_of_Department> empl_of_deps = new List<Employees_of_Department>()
        {
            new Employees_of_Department(1,1),
            new Employees_of_Department(2,1),
            new Employees_of_Department(3,2),
            new Employees_of_Department(4,2),
            new Employees_of_Department(5,1),
            new Employees_of_Department(6,1),
            new Employees_of_Department(7,3),
            new Employees_of_Department(8,3),
            new Employees_of_Department(9,3)
        };

        static void Main(string[] args)
        {
            // Сортировка сотрудников по отделу
            Console.WriteLine("Список сотрудников, отсортированных по отделу");
            var q1 = from x in employees
                     orderby x.department_id, x.employee_surname
                     select x;
            foreach (var x in q1)
                Console.WriteLine(x);

            // Сотрудники с фамилией на А
            Console.WriteLine("\nСписок сотрудников с фамилией на А \n");
            var q3 = from x in employees
                     where (x.employee_surname[0].ToString().ToUpper() == "А")
                     select x;
            foreach (var x in q3)
                Console.WriteLine(x);

            // Количество сотрудников в отделах
            Console.WriteLine("\nСписок отделов с количеством сотрудников в них");
            var q4 = from x in employees
                     group x by x.department_id into egrp
                     select new { ID = egrp.Key, Value = egrp.Count()};
            foreach(var x in q4)
            {
                Department dtemp = new Department(0, " ");

                var f1 = (from y in departments select y).First(y => y.department_id == x.ID);
                dtemp = f1;

                Console.WriteLine(dtemp.department_name + ": " + x.Value.ToString());
            }

            // Отделы, в которых у всех сотрудников фамилия на А
            Console.WriteLine("\nСписок отделов, в которых у всех сотрудников фамилия начинается на А");
            var q5 = from x in q3
                     group x by x.department_id into egrp
                     select new { ID = egrp.Key, Value = egrp.Count()};

            foreach (var x in q5)
            { 
               foreach(var y in q4)
                {  
                   if(x.ID == y.ID && x.Value == y.Value)
                    {
                        Department dtemp = new Department(0, " ");

                       var f1 = (from z in departments select z).First(z => z.department_id == x.ID);
                       dtemp = f1;

                       Console.WriteLine(dtemp.department_name);
                    }
                }
            }

            // Отделы, в которых хотя бы у одного сотрудника фамилия на А
            Console.WriteLine("\nСписок отделов, в которых хотя бы у одного сотрудника фамилия начинается на А");
            foreach (var x in q5)
            {
                foreach (var y in q4)
                {
                    if (x.ID == y.ID)
                    {
                        Department dtemp = new Department(0, " ");

                        var f1 = (from z in departments select z).First(z => z.department_id == x.ID);
                        dtemp = f1;

                        Console.WriteLine(dtemp.department_name);
                    }
                }
            }

            // Список сотрудников каждого отдела
            Console.WriteLine("\nСписок отделов и сотрудников в них");
            var q6 = from y in departments
                     join l1 in empl_of_deps on y.department_id equals l1.department_id into temp1
                     from t1 in temp1
                     join l2 in employees on t1.employee_id equals l2.employee_id into temp2
                     from t2 in temp2
                     select new {ID_d = t1.department_id, Name_d = y.department_name, ID_e = t1.employee_id, Name_e = t2.employee_surname};

            foreach(var i in departments)
            {
                Console.WriteLine("\n" + i.department_name + ":");
                foreach(var x in q6)
                {
                    if (x.ID_d == i.department_id)
                        Console.WriteLine(x.Name_e);
                }
            }


            // Количество сотрудников в отделах
            Console.WriteLine("\nСписок отделов и количество сотрудников в них");
            var q7 = from x in employees
                     group x by x.department_id into egrp
                     select new { ID = egrp.Key, Value = egrp};

            foreach (var x in q7)
            {
                Department dtemp = new Department(0, " ");
                var f1 = (from y in departments select y).First(y => y.department_id == x.ID);
                dtemp = f1;

                Console.WriteLine(dtemp.department_name + ": " + x.Value.Count().ToString());
            }
            Console.ReadLine();
        }
    }
}
