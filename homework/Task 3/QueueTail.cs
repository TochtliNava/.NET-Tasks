using homework._Task3;
using System;

namespace homework.Task_3
{
    internal static class QueueTail
    {
        public static Queue<T> Tail<T>(this IQueue<T> queue)
        {
            if (!(queue is Queue<T> tail))
            {
                throw new Exception("This is not a Queue<T> type.");
            }
            tail.Dequeue();
            return tail;
        }
    }
}
