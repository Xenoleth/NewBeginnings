using System;
using Task1.Models;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Arr<Employee> employees = new Arr<Employee>();
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
            
            for (int i = 0; i <= employees.Length; i++)
            {
                Employee employee = employees.GetByIndex(i);
                Console.WriteLine(employee);
            }

            Console.ReadLine();
        }

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
