// O(n) representation

using System.ComponentModel;

void BigOn(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(i);
    }
}

//BigOn(5);

// Output
// 0
// 1
// 2
// 3
// 4


// **********


// O(n^2) representation

void BigOn2(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine(i + " " + j);
        }
    }
}

// BigOn2(5);

// Output
// 0 0
// 0 1
// 0 2
// 0 3
// 0 4
// 1 0
// 1 1
// 1 2
// 1 3
// 1 4
// 2 0
// 2 1
// 2 2
// 2 3
// 2 4
// 3 0
// 3 1
// 3 2
// 3 3
// 3 4
// 4 0
// 4 1
// 4 2
// 4 3
// 4 4


// **********


// O(n^3) representation

void BigOn3(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(i + " " + j + " " + k);
            }
        }
    }
}

//BigOn3(5);

// Output
// 0 0 0
// 0 0 1
// 0 0 2
// 0 0 3
// 0 0 4
// 0 1 0
// 0 1 1
// 0 1 2
// 0 1 3
// 0 1 4
// 0 2 0
// 0 2 1
// 0 2 2
// 0 2 3
// 0 2 4
// 0 3 0
// 0 3 1
// 0 3 2
// 0 3 3
// 0 3 4
// 0 4 0
// 0 4 1
// 0 4 2
// 0 4 3
// 0 4 4
// 1 0 0
// 1 0 1
// 1 0 2
// 1 0 3
// 1 0 4
// 1 1 0
// 1 1 1
// 1 1 2
// 1 1 3
// 1 1 4
// 1 2 0
// 1 2 1
// 1 2 2
// 1 2 3
// 1 2 4
// 1 3 0
// 1 3 1
// 1 3 2
// 1 3 3
// 1 3 4
// 1 4 0
// 1 4 1
// 1 4 2
// 1 4 3
// 1 4 4
// 2 0 0
// 2 0 1
// 2 0 2
// 2 0 3
// 2 0 4
// 2 1 0
// 2 1 1
// 2 1 2
// 2 1 3
// 2 1 4
// 2 2 0
// 2 2 1
// 2 2 2
// 2 2 3
// 2 2 4
// 2 3 0
// 2 3 1
// 2 3 2
// 2 3 3
// 2 3 4
// 2 4 0
// 2 4 1
// 2 4 2
// 2 4 3
// 2 4 4
// 3 0 0
// 3 0 1
// 3 0 2
// 3 0 3
// 3 0 4
// 3 1 0
// 3 1 1
// 3 1 2
// 3 1 3
// 3 1 4
// 3 2 0
// 3 2 1
// 3 2 2
// 3 2 3
// 3 2 4
// 3 3 0
// 3 3 1
// 3 3 2
// 3 3 3
// 3 3 4
// 3 4 0
// 3 4 1
// 3 4 2
// 3 4 3
// 3 4 4
// 4 0 0
// 4 0 1
// 4 0 2
// 4 0 3
// 4 0 4
// 4 1 0
// 4 1 1
// 4 1 2
// 4 1 3
// 4 1 4
// 4 2 0
// 4 2 1
// 4 2 2
// 4 2 3
// 4 2 4
// 4 3 0
// 4 3 1
// 4 3 2
// 4 3 3
// 4 3 4
// 4 4 0
// 4 4 1
// 4 4 2
// 4 4 3
// 4 4 4

// *********

// O(logn)

void LogN(int n)
{
    while (n > 1)
    {
        n = (int)Math.Floor((decimal)n / 2);
        Console.WriteLine(n);
    }
}

// LogN(8);

// Output
// 4
// 2
// 1

// *******

// O(nlogn) representation

void NLogN(int n)
{
    int lim = n;
    while (n > 1)
    {
        n = (int)Math.Floor((decimal)n / 2);
        for (int i = 0; i < lim; i++)
        {
            Console.WriteLine(i);
        }
    }
}

// NLogN(16);

// Output
// 0
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8
// 9
// 10
// 11
// 12
// 13
// 14
// 15
// 0
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8
// 9
// 10
// 11
// 12
// 13
// 14
// 15
// 0
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8
// 9
// 10
// 11
// 12
// 13
// 14
// 15
// 0
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8
// 9
// 10
// 11
// 12
// 13
// 14
// 15


// *******

// O(n!)

void NFactorial(int n)
{
    if (n == 0)
    {
        Console.WriteLine("1");
        return;
    }
    else
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i);
            NFactorial(n - 1); //recursive
        }
    }
}

// NFactorial(3);

// Output
// 0
// 0
// 0
// 1
// 1
// 0
// 1
// 1
// 0
// 0
// 1
// 1
// 0
// 1
// 2
// 0
// 0
// 1
// 1
// 0
// 1

// ******

// Actual Factorial

int counter = 0;
int ActualFactorial(int n)
{
    counter += 1;
    Console.WriteLine(counter);
    if (n == 1 || n == 0)
    {
        return 1;
    }
    else
    {
        return (n * ActualFactorial(n - 1));
    }
}

ActualFactorial(8);

// Output
// 1
// 2
// 3
// 4
// 5
// 6
// 7
// 8

