public class QueueExample
{
    public static void Main(string[] args)
    {

        Queue<string> myQueue = new Queue<string>();


        myQueue.Enqueue("First");
        myQueue.Enqueue("Second");
        myQueue.Enqueue("Third");
        myQueue.Enqueue("Fourth");


        Console.WriteLine("Elements in the queue:");
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }


        string dequeuedItem = myQueue.Dequeue();
        Console.WriteLine("Dequeued item: " + dequeuedItem);

        string frontItem = myQueue.Peek();
        Console.WriteLine("Front item in the queue: " + frontItem);


        int count = myQueue.Count;
        Console.WriteLine("Number of elements in the queue: " + count);


        myQueue.Clear();
        Console.WriteLine("Cleared the queue");


        bool isEmpty = myQueue.Count == 0;
        Console.WriteLine("Is the queue empty after clearing? " + isEmpty);
    }
}
