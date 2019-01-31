using System;
using Task1.Models;

namespace Task1
{
    public class Arr
    {
        private Employee[] _employees;

        private int _capacity;
        private int _index;

        public Arr()
        {
            _index = 0;
            _capacity = 1;
            _employees = new Employee[_capacity];
        }

        public int Length => _index;
        
        public void Add(Employee employee)
        {
            if (_capacity == _index)
            {
                EnlargeArray();
            }

            _employees[_index] = employee;
            _index++;
        }

        public Employee GetByIndex(int index)
        {
            if (index > _index)
            {
                throw new Exception("Index out of bounds of array.");
            }

            return _employees[index];
        }

        private void EnlargeArray()
        {
            _capacity *= 2;
            Employee[] newEmployees = new Employee[_capacity];

            CopyArray(_employees, newEmployees);

            _employees = newEmployees;
        }

        private void CopyArray(Employee[] source, Employee[] destination)
        {
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }
        }
    }
}
