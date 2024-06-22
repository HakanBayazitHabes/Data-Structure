/*

Deque()

addRight()
addLeft()

removeRight()
removeLeft()

isEmpty()
size()

*/


namespace CustomDeque
{
    class CustomDeque<T>
    {
        private List<T> elements;

        public CustomDeque() => elements = [];

        public void AddRight(T element) => elements.Add(element);

        public void AddLeft(T element) => elements.Insert(0, element);

        public void RemoveRight() => elements.RemoveAt(elements.Count - 1);

        public void RemoveLeft() => elements.RemoveAt(0);

        public bool IsEmpty() => elements.Count == 0;

        public int Size() => elements.Count;

        public void PrintAllElements()
        {
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            var myDeque = new CustomDeque<int>();

            myDeque.AddRight(10);

            myDeque.AddRight(20);

            myDeque.AddLeft(30);

            myDeque.AddLeft(40);

            myDeque.AddRight(50);

            Console.WriteLine(myDeque.Size());

            myDeque.RemoveLeft();

            myDeque.PrintAllElements();
        }
    }
}






