using System;
using Task1.Models;

namespace Task1
{
    public class List<T> : ICollection<T>
    {
        private T[] _employees;

        private int _capacity;
        private int _count;

        public List()
        {
            _count = 0;
            _capacity = 1;
            _employees = new T[_capacity];
        }

        public int Count => _count;
        //public int Count
        //{
        //    get
        //    {
        //        return _count;
        //    }
        //}

        public T this[int i]
        {
            get { return _employees[i]; }
            set { _employees[i] = value; }
        }

        public void Add(T employee)
        {
            if (_capacity == _count)
            {
                EnlargeArray();
            }

            _employees[_count] = employee;
            _count++;
        }

        public T GetByIndex(int index)
        {
            if (index > _count)
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
