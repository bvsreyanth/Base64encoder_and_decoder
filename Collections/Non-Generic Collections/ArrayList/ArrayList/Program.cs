using System;
using System.Collections.Generic;

public class ListExample
{
    public static void Main(string[] args)
    {
        
        List<string> fruits = new List<string>();

        
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");
        fruits.Add("Mango");

      
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        fruits.Insert(2, "Grapes");

        fruits.Remove("Orange");


        int size = fruits.Count;
        Console.WriteLine("\nSize of the List: " + size);

        bool containsBanana = fruits.Contains("Banana");
        Console.WriteLine("Does the list contain Banana? " + containsBanana);

        fruits.RemoveAt(0);

        // Clearing the List
        fruits.Clear();

 
        bool isEmpty = fruits.Count == 0;
        Console.WriteLine("Is the list empty? " + isEmpty);
    }
}
