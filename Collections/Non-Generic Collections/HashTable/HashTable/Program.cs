using System.Collections;

public class HashTable
{
    public static void Main(string[] args)
    {

        Hashtable ht = new Hashtable();


        ht.Add("Name", "John");
        ht.Add("Age", 30);
        ht.Add("City", "New York");


        Console.WriteLine("Name: " + ht["Name"]);
        Console.WriteLine("Age: " + ht["Age"]);
        Console.WriteLine("City: " + ht["City"]);


        bool containsAge = ht.Contains("Age");
        Console.WriteLine("Does the HashTable contain the key 'Age'? " + containsAge);


        ht.Remove("City");


        int count = ht.Count;
        Console.WriteLine("Number of elements in the HashTable: " + count);


        bool isEmpty = ht.Count == 0;
        Console.WriteLine("Is the HashTable empty? " + isEmpty);


        ht.Clear();
        Console.WriteLine("Cleared the HashTable");


        isEmpty = ht.Count == 0;
        Console.WriteLine("Is the HashTable empty after clearing? " + isEmpty);
    }
}
