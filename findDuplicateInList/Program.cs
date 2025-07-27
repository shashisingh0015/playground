Console.WriteLine("Enter comma separated integers for the list:");
string? input = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("No input provided.");
    return;
}

string[] inputArray = input.Split(',');
List<int> numbers = new List<int>();
foreach (string str in inputArray)
{
    if (int.TryParse(str.Trim(), out int number))
    {
        numbers.Add(number);
    }
    else
    {
        Console.WriteLine($"Invalid number: {str.Trim()}");
    }
}

if (numbers.Count == 0)
{
    Console.WriteLine("No valid integers provided.");
    return;
}

if (numbers.Count <= 0)
{
    Console.WriteLine("List is empty or has no valid integers.");
    return;
}

List<int> duplicates = FindDuplicates(numbers);

Console.WriteLine("Duplicate numbers: " + string.Join(", ", duplicates));

List<int> FindDuplicates(List<int> nums)
{
    var seen = new HashSet<int>();
    var dupes = new HashSet<int>();
    foreach (int num in nums)
    {
        if (!seen.Add(num))
        {
            dupes.Add(num);
        }
    }
    return dupes.ToList();
}