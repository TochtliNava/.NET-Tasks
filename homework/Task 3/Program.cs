using System.Collections;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(4);
            queue.Enqueue(1);
            //  Gives an error
            //queue.Tail();
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(7);
            //  Gives a size error
            //queue.Enqueue(9);
            Queue<int> tailQueue = queue.Tail();
            tailQueue.Dequeue();
            tailQueue.Dequeue();
            //  Gives another error
            //tailQueue.Tail();
            tailQueue.Dequeue();
            bool isEmpty = tailQueue.IsEmpty();     //  True
            tailQueue.Dequeue();
            isEmpty = tailQueue.IsEmpty();
            tailQueue.Enqueue(6);
        }
    }
}
