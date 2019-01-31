using System;
using Task1.Models;

namespace Task1
{
    public class Arr<T>
    {
        private T[] _employees;

        private int _capacity;
        private int _index;

        public Arr()
        {
            _index = 0;
            _capacity = 1;
            _employees = new T[_capacity];
        }

        public int Length => _index;
        
        public void Add(T employee)
        {
            if (_capacity == _index)
            {
                EnlargeArray();
            }

            _employees[_index] = employee;
            _index++;
        }

        public T GetByIndex(int index)
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
            T[] newEmployees = new T[_capacity];

            CopyArray(_employees, newEmployees);

            _employees = newEmployees;
        }

        private void CopyArray(T[] source, T[] destination)
        {
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }
        }
    }
}
