/*
Kendi Stack() imizi oluşturalım

push(item)
pop()
showLast()
size()
isEmpty()

*/

namespace CustomStack
{
    public class CustomStack<T>
    {
        List<T> elements;
        public CustomStack() => elements = [];

        public bool IsEmpty() => elements.Count == 0;

        public void Push(T element) => elements.Add(element);

        public T Pop()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T lastElement = elements.Last();
            elements.RemoveAt(elements.Count - 1);
            return lastElement;
        }
        public T ShowLast() => elements.LastOrDefault();

        public int Size() => elements.Count;
    }

    public class Program
    {
        public static void Main()
        {
            var myStack = new CustomStack<int>();

            Console.WriteLine("Is Empty : " + myStack.IsEmpty());

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(40);

            Console.WriteLine("Show Last Element : " + myStack.ShowLast());

            Console.WriteLine("Pop : " + myStack.Pop());
            Console.WriteLine("Show Last Element : " + myStack.ShowLast());
            Console.WriteLine("Pop : " + myStack.Pop());
            Console.WriteLine("Show Last Element : " + myStack.ShowLast());
            Console.WriteLine("Pop : " + myStack.Pop());
            Console.WriteLine("Show Last Element : " + myStack.ShowLast());
            Console.WriteLine("Pop : " + myStack.Pop());
            Console.WriteLine("Show Last Element : " + myStack.ShowLast());

        }
    }
}