namespace Task1.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public string Department { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Department: {Department}, Age: {Age}";
        }
    }
}
