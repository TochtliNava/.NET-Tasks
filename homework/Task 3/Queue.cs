using System;

namespace task3
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
            if (LastItem == 0)
            {
                _queue = new T[Size];
                return;
            }
            T[] tempQueue = new T[Size];
            for (int i = 0; i < Size - 1; i++)
            {
                tempQueue[i] = _queue[i + 1];
            }
            _queue = tempQueue;
            LastItem--;
        }

        public bool IsEmpty()
        {
            return LastItem == 0 ? true : false;
        }

        public Queue<T> Tail()
        {
            if (Size == 1 || LastItem == 1 || LastItem == 0)
            {
                throw new Exception("Can't perform Tail() Method: The Queue size/elements is 1 or is empty");
            }
            T[] tail = new T[Size - 1];
            for (int i = 0; i < Size - 1; i++)
            {
                tail[i] = _queue[i + 1];
            }
            return new Queue<T>(tail);
        }
    }
}
