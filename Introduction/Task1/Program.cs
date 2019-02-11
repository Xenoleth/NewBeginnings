using System;
using Task1.Models;

namespace Task1
{
    class Program
    {
        private readonly ICollection<Employee> _employees;

        public Program(ICollection<Employee> employees)
        {
            _employees = employees;
        }

        static void Main(string[] args)
        {
            ICollection<Employee> employees = new List<Employee>();
            Console.WriteLine(employees.ToString());

            bool open = true;
            while (open)
            {
                Console.WriteLine("Do you want to continue? y/n");
                string command = Console.ReadLine();
                if (command == "n")
                {
                    break;
                }

                Employee employee = GetEmployee();
                employees.Add(employee);
            }
            
            for (int i = 0; i <= employees.Count; i++)
            {
                Employee employee = employees.GetByIndex(i);
                Console.WriteLine(employee);
            }

            Console.WriteLine("Enter department name:");
            string department = Console.ReadLine();

            ICollection<Employee> employeesInDepartemntIt = GetEmployees<Employee, int>(employees, e => e.Department == "IT");

            for (int i = 0; i < employeesInDepartemntIt.Count; i++)
            {
                Console.WriteLine(employeesInDepartemntIt[i].Name);
            }

            Console.ReadLine();
        }

        //public static bool IsDepartment(Employee employee, string department)
        //{
        //    return employee.Department == department;
        //}

        //public static bool HasName(Employee employee, string name)
        //{
        //    return employee.Name == name;
        //}

        //public static bool HasAge(Employee employee, int age123)
        //{
        //    return employee.Age == age123;
        //}

        //public static string Name(Employee employee, string name)
        //{
        //    return employee.Name;
        //}

        //public delegate bool MyPredicate<T>(Employee employee, T value);

        public static ICollection<T> GetEmployees<T, U>(ICollection<T> employees, Func<T, bool> predicate)
        {
            ICollection<T> employeesInDepartemntIt = new List<T>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (predicate(employees[i]))
                {
                    employeesInDepartemntIt.Add(employees[i]);
                }
            }

            if (employeesInDepartemntIt.Count == 0)
            {
                throw new Exception("No employees in this department");
            }

            return employeesInDepartemntIt;
        }

        //public static ICollection<T> GetEmployees<T, U>(ICollection<T> employees, MyPredicate<U> predicate, U value) where T : Employee
        //{
        //    ICollection<T> employeesInDepartemntIt = new List<T>();
        //    for (int i = 0; i < employees.Count; i++)
        //    {
        //        if (predicate(employees[i], value))
        //        {
        //            employeesInDepartemntIt.Add(employees[i]);
        //        }
        //    }

        //    if (employeesInDepartemntIt.Count == 0)
        //    {
        //        throw new Exception("No employees in this department");
        //    }

        //    return employeesInDepartemntIt;
        //}

        public static Employee GetEmployee()
        {
            Console.WriteLine("Enter employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee department:");
            string department = Console.ReadLine();

            Console.WriteLine("Enter employee age:");
            string ageText = Console.ReadLine();
            int age = int.Parse(ageText);

            Employee employee = new Employee
            {
                Name = name,
                Department = department,
                Age = age
            };

            return employee;
        }
    }
}
