namespace DataStructures.Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private readonly List<T> list = [];
        public int Count { get; private set; }

        public T DeQueue()
        {
            if (Count == 0)
                throw new Exception("Empty queue!");

            var temp = list[0];
            list.RemoveAt(0);
            Count--;
            return temp;
        }

        public void EnQueue(T value)
        {
            ArgumentNullException.ThrowIfNull(value);
            list.Add(value);
            Count++;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new ArgumentNullException();
            return list[0];
        }
    }

}