/* Kendi Queue() imizi oluşturalım enqueue(element) dequeue() size() isEmpty() */
using System;
using System.Collections.Generic;

namespace CustomQueue
{
    class CustomQueue<T>
    {
        private List<T> elements;

        public CustomQueue() => elements = [];

        public bool IsEmpty() => elements.Count == 0;

        public void Enqueue(T element) => elements.Insert(0, element);

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T LastElement = elements.Last();
            elements.RemoveAt(elements.Count - 1);
            return LastElement;
        }

        public int Size => elements.Count;
    }

    class Program
    {
        public static void Main()
        {
            CustomQueue<int> myQueue = new CustomQueue<int>();
            Console.WriteLine(myQueue.IsEmpty); // True

            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Size);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Size);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Size);


        }
    }
}