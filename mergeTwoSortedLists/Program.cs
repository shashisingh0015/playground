int[] arr1 = { 1, 3, 5, 8 };
int[] arr2 = { 2, 3, 5, 7, 8, 10 };

int[] mergedArray = MergedArray(arr1, arr2);

Console.WriteLine("Merged Array: " + string.Join(",", mergedArray));

int[] MergedArray(int[] arr1, int[] arr2)
{
    List<int> result = new List<int>();
    int i = 0, j = 0;

    while (i < arr1.Length && j < arr2.Length)
    {
        if (arr1[i] < arr2[j])
        {
            result.Add(arr1[i]);
            i++;
        }
        else
        {
            result.Add(arr2[j]);
            j++;
        }
    }

    while (i < arr1.Length)
    {
        result.Add(arr1[i]);
        i++;
    }
    while (j < arr2.Length)
    {
        result.Add(arr2[j]);
        j++;
    }
    return result.ToArray();
}