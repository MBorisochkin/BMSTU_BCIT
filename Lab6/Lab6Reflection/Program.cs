using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Reflection
{
    class Program
    {
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            bool Result = false;
            attribute = null;

            //Поиск атрибутов с заданным типом
            var isAttribute = checkType.GetCustomAttributes(attributeType, false);
            if (isAttribute.Length > 0)
            {
                Result = true;
                attribute = isAttribute[0];
            }

            return Result;
        }

        /// <summary>
        /// Получение информации о текущей сборке
        /// </summary>
        static void AssemblyInfo()
        {
            Console.WriteLine("Вывод информации о сборке:");
            Assembly i = Assembly.GetExecutingAssembly();
            Console.WriteLine("Полное имя:" + i.FullName);
            Console.WriteLine("Исполняемый файл:" + i.Location);
        }

        /// <summary>
        /// Получение информации о типе
        /// </summary>
        static void TypeInfo()
        {
            Flat obj = new Flat();
            Type t = obj.GetType();

            //другой способ
            //Type t = typeof(ForInspection);

            Console.WriteLine("\nИнформация о типе:");
            Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
            Console.WriteLine("Пространство имен " + t.Namespace);
            Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);

            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nFlat реализует IComparable -> " +
            t.GetInterfaces().Contains(typeof(IComparable))
            );
        }

        /// <summary>
        /// Работа с атрибутами
        /// </summary>
        static void AttributeInfo()
        {
            Type t = typeof(Flat);
            Console.WriteLine("\nСвойства, помеченные атрибутом:");
            foreach (var x in t.GetProperties())
            {
                object attrObj;
                if (GetPropertyAttribute(x, typeof(NewAttribute), out attrObj))
                {
                    NewAttribute attr = attrObj as NewAttribute;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }
        }

        /// <summary>
        /// Вызов метода класса с помощью рефлексии
        /// </summary>
        static void InvokeMemberInfo()
        {
            Type t = typeof(Flat);
            Console.WriteLine("\nВызов метода:");
           
            Flat fi = (Flat)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });

            //Параметры вызова метода
            object[] parameters = new object[] { 3, 72.5 };
            //Вызов метода
            object Result = t.InvokeMember("CountPrice", BindingFlags.InvokeMethod, null, fi, parameters);
            Console.WriteLine("CountPrice(3, 72.5)={0}", Result);
        }

        static void Main(string[] args)
        {
            AssemblyInfo();
            TypeInfo();
            AttributeInfo();
            InvokeMemberInfo();

            Console.ReadLine();
        }
    }
}
