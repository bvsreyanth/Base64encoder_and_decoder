using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
       
        Stack<int> numberStack = new Stack<int>();

        numberStack.Push(10);
        numberStack.Push(20);
        numberStack.Push(30);
        numberStack.Push(40);

        Console.WriteLine("Elements in the stack:");
        foreach (var number in numberStack)
        {
            Console.WriteLine(number);
        }

        int topElement = numberStack.Peek();
        Console.WriteLine("Top element in the stack: " + topElement);

        int poppedElement = numberStack.Pop();
        Console.WriteLine("Popped element: " + poppedElement);

        int count = numberStack.Count;
        Console.WriteLine("Number of elements in the stack: " + count);

        numberStack.Clear();
        Console.WriteLine("Cleared the stack");

        bool isEmpty = numberStack.Count == 0;
        Console.WriteLine("Is the stack empty after clearing? " + isEmpty);
    }
}
