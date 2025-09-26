using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> ages = new Dictionary<string, int>();

        ages.Add("Alice", 25);
        ages.Add("Bob", 30);
        ages.Add("Charlie", 22);
        ages.Add("David", 28);

        Console.WriteLine("Age of Bob: " + ages["Bob"]);

        Console.WriteLine("All ages in the dictionary:");
        foreach (var kvp in ages)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        bool containsCharlie = ages.ContainsKey("Charlie");
        Console.WriteLine("Does the dictionary contain the key 'Charlie'? " + containsCharlie);

        ages.Remove("Alice");

        int count = ages.Count;
        Console.WriteLine("Number of elements in the dictionary: " + count);

        ages.Clear();
        Console.WriteLine("Cleared the dictionary");

        bool isEmpty = ages.Count == 0;
        Console.WriteLine("Is the dictionary empty after clearing? " + isEmpty);
    }
}
