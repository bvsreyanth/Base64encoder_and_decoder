using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
      
        SortedList<string, int> ages = new SortedList<string, int>();

        ages.Add("Alice", 25);
        ages.Add("Bob", 30);
        ages.Add("Charlie", 22);
        ages.Add("David", 28);

        Console.WriteLine("Age of Bob: " + ages["Bob"]);

        Console.WriteLine("All ages in the sorted list:");
        foreach (var kvp in ages)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        bool containsCharlie = ages.ContainsKey("Charlie");
        Console.WriteLine("Does the sorted list contain the key 'Charlie'? " + containsCharlie);

        ages.Remove("Alice");

        int count = ages.Count;
        Console.WriteLine("Number of elements in the sorted list: " + count);

        ages.Clear();
        Console.WriteLine("Cleared the sorted list");

        bool isEmpty = ages.Count == 0;
        Console.WriteLine("Is the sorted list empty after clearing? " + isEmpty);
    }
}
