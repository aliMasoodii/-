using System;

class Fibonachi
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(value: fib(number));
    }
    public static int fib(int number)
    {
        int a = 0;
        int b = 1;
        for (int i = 0; i < number; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }
}