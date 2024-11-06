
namespace DataStructures.Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        public int Count { get; private set; }

        private readonly SinglyLinkedList<T> list = new SinglyLinkedList<T>();

        public T Peek()
        {
            if (Count == 0) throw new Exception("Empty Stack");
            return list.Head.Value;
        }

        public T Pop()
        {
            if (Count == 0) throw new Exception("Empty Stack");
            var temp = list.RemoveFirst();
            Count--;
            return temp;
        }

        public void Push(T value)
        {
            ArgumentNullException.ThrowIfNull(value);

            list.AddFirst(value);
            Count++;
        }
    }
}
