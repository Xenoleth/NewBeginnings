using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            double number2 = 2d;
            decimal number3 = 2;
            string str = "Hello World";
            float fl = 3f;
            var num1 = 2m;
            bool asd = true;

            Person pers1 = new Person("Ime", "Prezime", "Familiq");

            Person pers2 = new Person("Ime20", "asd", pers1.LastName);
            //Person pers = new Person();
            //pers.SetFirstName("Ivan");
            //pers.LastName = "Stoqnov";
            //string familiq = pers.LastName;
            //pers.LastName = "Georgiev";
            ////pers.LastName = "Dimitrov";
            //string ime = pers.GetFirstName();
            //pers.Country = "Bulgaria";

            PrintPerston(pers1);
            //Console.WriteLine("~~~~~~~~");
            //pers.PrintPerston();

            Console.ReadLine();
        }

        public static void PrintPerston(Person pers)
        {
            Console.WriteLine(pers.GetFirstName());
            Console.WriteLine(pers.LastName);
            Console.WriteLine(pers.Country);
        }

        public class Person
        {
            protected string _firstName; // Field
            private string _lastName;
            protected int _age;

            public Person()
            {

            }

            public Person(string firstName, string lastName)
            {

            }

            public Person(string firstName, string middleName, string lastName)
            {
                this._firstName = firstName;
                _lastName = lastName;
            }

            public Person(string firstName, int lastName)
            {

            }

            public string Country { get;}

            public string LastName // Property
            {
                get
                {
                    return _lastName;
                }

                //set
                //{
                //    if (value == "Dimitrov")
                //    {
                //        _lastName = null;
                //        return;
                //    }

                //    this._lastName = value;
                //}
            }

            //public void SetFirstName(string firstName) // Method
            //{
            //    if (firstName == "Gosho")
            //    {
            //        return;
            //    }

            //    this._firstName = firstName;
            //}

            public string GetFirstName()
            {
                return _firstName;
            }

            //public void PrintPerston()
            //{
            //    Console.WriteLine(this.GetFirstName());
            //    Console.WriteLine(this.LastName);
            //    Console.WriteLine(this.Country);
            //}
        }

        public class Employee : Person
        {
            
        }

        public class Asd : Employee
        {

        }
    }
}
