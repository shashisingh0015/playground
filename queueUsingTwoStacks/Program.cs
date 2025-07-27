
QueueUsingTwoStacks<int> queue = new QueueUsingTwoStacks<int>();

Console.WriteLine("Enter integers to enqueue (comma separated):");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("No input provided.");
    return;
}

string[] inputArray = input.Split(',');
foreach (string str in inputArray)
{
    if (int.TryParse(str.Trim(), out int number))
    {
        queue.Enqueue(number);
    }
    else
    {
        Console.WriteLine($"Invalid number: {str.Trim()}");
    }
}

Console.WriteLine("Dequeueing elements:");
while (true)
{
    Console.WriteLine("Press Enter to dequeue an item or type 'exit' to quit:");
    string? command = Console.ReadLine();
if (command?.ToLower() == "exit")
    {
        break;
    }
    try
    {
        int dequeuedItem = queue.DeQueue();
        Console.WriteLine($"Dequeued: {dequeuedItem}");
    }
    catch (InvalidOperationException)
    {
        Console.WriteLine("Queue is empty.");
        break;
    }
}



class QueueUsingTwoStacks<T>
{
    private Stack<T> stackNew = new Stack<T>();
    private Stack<T> stackOld = new Stack<T>();

    public void Enqueue(T item)
    {
        stackNew.Push(item);
    }

    public T DeQueue()
    {
        ShiftStacks();
        if (stackOld.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return stackOld.Pop();
    }

    private void ShiftStacks()
    {
        if (stackOld.Count == 0)
        {
            while (stackNew.Count > 0)
            {
                stackOld.Push(stackNew.Pop());
            }
        }
    }
}