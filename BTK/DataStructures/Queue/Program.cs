namespace DataStructures.Queue
{
    public class Queue<T>
    {
        private readonly IQueue<T> queue;
        public int Count => queue.Count;

        public Queue(QueueType type = QueueType.Array)
        {
            if (type == QueueType.Array)
            {
                queue = new ArrayQueue<T>();
            }
            else
            {
                queue = new LinkedListQueue<T>();

            }
        }

        public void EnQueue(T value)
        {
            queue.EnQueue(value);
        }

        public T DeQueue()
        {
            return queue.DeQueue();
        }
        public T Peek()
        {
            return queue.Peek();
        }

    }

    public interface IQueue<T>
    {
        int Count { get; }
        void EnQueue(T value);
        T DeQueue();
        T Peek();
    }

    public enum QueueType
    {
        Array = 0,          // List<T>
        LinkedList = 1     // DoublyLinkedList<T>
    }

    class Program
    {
        static void Main()
        {
            var numbers = new int[] { 10, 20, 30 };
            var q1 = new Queue<int>();
            var q2 = new Queue<int>(QueueType.LinkedList);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
                q1.EnQueue(item);
                q2.EnQueue(item);
            }

            Console.WriteLine($"q1 Count : {q1.Count}");
            Console.WriteLine($"q1 Count : {q2.Count}");

            Console.WriteLine($"{q1.DeQueue()} has been removed from q1.");
            Console.WriteLine($"{q2.DeQueue()} has been removed from q1.");

            Console.WriteLine($"q1 Count : {q1.Count}");
            Console.WriteLine($"q1 Count : {q2.Count}");

            Console.WriteLine($"q1 Count : {q1.Peek()}");
            Console.WriteLine($"q1 Count : {q2.Peek()}");
        }
    }
}