class BaseballGame
{
    Stack<int> elements;
    readonly string[] operations = ["5", "-2", "4", "C", "D", "9", "+", "+"];

    public BaseballGame()
    {
        elements = [];
    }

    public int CallPoints()
    {
        int totalSum = 0;
        foreach (var item in operations)
        {
            switch (item)
            {
                case "C":
                    totalSum -= elements.Pop();
                    break;
                case "D":
                    int doubleElement = 2 * elements.Peek();
                    elements.Push(doubleElement);
                    totalSum += doubleElement;
                    break;
                case "+":
                    // int secondFirstElement = elements.ElementAt(1);
                    // int firstElement = elements.First();
                    // fist ve elementat methodları yerine yığından çıkartıp tekrar eklemek daha verimli
                    
                    int firstElement = elements.Pop();
                    int secondElement = elements.Peek();
                    int sum = firstElement + secondElement;
                    elements.Push(firstElement);
                    elements.Push(sum);
                    totalSum += sum;
                    break;
                default:
                    int num = int.Parse(item);
                    elements.Push(num);
                    totalSum += num;
                    break;
            }
        }

        return totalSum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BaseballGame baseballGame = new();

        Console.WriteLine(baseballGame.CallPoints());
    }
}



