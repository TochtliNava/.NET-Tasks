using System.Collections;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(4);
            queue.Enqueue(1);
            //queue.Tail();
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(7);
            Queue<int> tailQueue = queue.Tail();
            tailQueue.Dequeue();
            tailQueue.Dequeue();
            //tailQueue.Tail();
            tailQueue.Dequeue();
            bool isEmpty = tailQueue.IsEmpty();
            tailQueue.Dequeue();
            isEmpty = tailQueue.IsEmpty();
            tailQueue.Enqueue(6);
        }
    }
}
