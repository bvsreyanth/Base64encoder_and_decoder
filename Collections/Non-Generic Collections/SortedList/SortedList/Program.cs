public class SortedList
{
    public static void Main(string[] args)
    {

        SortedList<string, int> ages = new SortedList<string, int>();

        // Adding key-value pairs 
        ages.Add("Alice", 25);
        ages.Add("Bob", 30);
        ages.Add("Charlie", 22);
        ages.Add("David", 28);


        Console.WriteLine("Age of Bob: " + ages["Bob"]);


        Console.WriteLine("All ages in the SortedList:");
        foreach (var kvp in ages)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }


        bool containsCharlie = ages.ContainsKey("Charlie");
        Console.WriteLine("Does the SortedList contain the key 'Charlie'? " + containsCharlie);

        // Removing 
        ages.Remove("Alice");


        int count = ages.Count;
        Console.WriteLine("Number of elements in the SortedList: " + count);


        ages.Clear();
        Console.WriteLine("Cleared the SortedList");

        bool isEmpty = ages.Count == 0;
        Console.WriteLine("Is the SortedList empty after clearing? " + isEmpty);
    }
}
