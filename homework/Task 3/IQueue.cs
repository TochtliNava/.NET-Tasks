namespace homework._Task3
{
    internal interface IQueue<T>
    {
        void Enqueue(T element);
        void Dequeue();
        bool IsEmpty();
    }
}
