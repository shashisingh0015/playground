Console.WriteLine("Binary Search Example");
Console.WriteLine("Enter a sorted list of integers separated by spaces:");
string? input = Console.ReadLine();

int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);
Console.WriteLine("Enter the number to search for:");
int target = Convert.ToInt32(Console.ReadLine());

int result = BinarySearch(numbers, target);

if (result != -1)
{
    Console.WriteLine($"Number found at index: {result}");
}
else
{
    Console.WriteLine("Number not found in the list.");
}   

int BinarySearch(int[] arr, int target)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
        int mid = (left + (right - left)) / 2;

        if (arr[mid] == target)
        {
            return mid;
        }

        if (arr[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    return -1; // Target not found
}