using DoublyLinkedList;

namespace DataStructures.Queue
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private readonly DoublyLinkedList<T> list = [];
        public int Count { get; set; }

        public T DeQueue()
        {
            if (Count == 0)
                throw new Exception("Empty queue!");
            var temp = list.RemoveFirst();
            Count--;
            return temp;
        }

        public void EnQueue(T value)
        {
            ArgumentNullException.ThrowIfNull(value);

            list.AddLast(value);
            Count++;
        }

        public T Peek() => Count == 0 ? throw new Exception("Empty queue!") : list.Head.Value;
        // {
        //     if (Count == 0)
        //         throw new Exception("Empty  queue!");

        //     return list.Head.Value;
        // }
    }

}