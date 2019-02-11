using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class AList<T> : ICollection<T>
    {
        public T this[int i] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public void Add(T employee)
        {
            throw new NotImplementedException();
        }

        public T GetByIndex(int index)
        {
            throw new NotImplementedException();
        }
    }
}
