using System;

namespace homework._Task3
{
    internal class Queue<T> : IQueue<T>
    {
        private T[] _queue;
        private int _tail = 0;

        public int Size { get { return _queue.Length; } }
        private int LastItem { 
            get
            {
                return _tail;
            } 
            set
            {
                _tail = value;
            }
        }

        public Queue(int maxSize) 
        {
            _queue = new T[maxSize];
        }

        public Queue(T[] queue)
        {
            _queue = queue;
            LastItem = queue.Length;
        }

        public Queue(T[] queue, int lastItem)
        {
            _queue = queue;
            LastItem = lastItem;
        }

        public void Enqueue(T element)
        {
            if (LastItem == Size)
            {
                throw new Exception("Can't perform Enqueue() Method: The Queue is full");
            }
            _queue[LastItem] = element;
            LastItem++;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Couldn't perform Dequeue(): Queue is empty");
            }
            for (int i = 0; i < Size - 1; i++)
            {
                _queue[i] = _queue[i + 1];
            }
            _queue[Size - 1] = default(T);
            LastItem--;
        }

        public bool IsEmpty() => LastItem == 0;
    }
}
