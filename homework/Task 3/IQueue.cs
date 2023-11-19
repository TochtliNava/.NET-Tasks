namespace task3
{
    internal interface IQueue<T>
    {
        void Enqueue(T element);
        void Dequeue();
        bool IsEmpty();
        Queue<T> Tail();
    }
}
