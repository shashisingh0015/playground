int[] numbers = { 54, 65, 61, 93, 22 };
int maxNumber = FindMax(numbers);

int FindMax(int[] nums)
{
    int max = nums[0];
    for (int i = 1; i < nums.Length; i++)
    {
        if (max < nums[i])
        {
            max = nums[i];
        }
    }
    return max;
}

Console.WriteLine("Largest number in array is {0}", maxNumber);