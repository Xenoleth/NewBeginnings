namespace Task1
{
    public interface ICollection<T>
    {
        void Add(T employee);

        T GetByIndex(int index);

        int Count { get; }

        T this[int i] { get; set; }
    }
}
