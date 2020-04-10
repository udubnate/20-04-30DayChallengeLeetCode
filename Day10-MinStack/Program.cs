using System;

namespace Day10_MinStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MinStack obj = new MinStack();
            obj.Push(-2);
            obj.Push(0);
            obj.Push(-3);
            int min1 = obj.GetMin(); // Returns - 3.
            obj.Pop();
            int top = obj.Top(); // Returns 0.
            int min2 = obj.GetMin(); // Returns - 2.

            Console.WriteLine("Hello World!");
        }
    }
}
