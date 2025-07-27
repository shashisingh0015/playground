using System.Transactions;

Console.WriteLine("Enter the 1st string:");
string? str1 = Console.ReadLine();
Console.WriteLine("enter the 2nd string:");
string? str2 = Console.ReadLine();

if (string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2))
{
    Console.WriteLine("Both strings must be provided.");
    return;
}

if (str1.Length != str2.Length)
{
    Console.WriteLine("Strings are not anagrams: different lengths.");
    return;
}

if (AreAnagrams(str1, str2))
{
    Console.WriteLine("Strings are anagrams.");
}
else
{
    Console.WriteLine("Strings are not anagrams.");
}

bool AreAnagrams(string s1, string s2)
{
    int[] charCount = new int[256];

    foreach (char c in s1)
    {
        charCount[c]++;
    }

    foreach (char c in s2)
    {
        charCount[c]--;
        if (charCount[c] < 0)
        {
            return false; // More occurrences of c in s2 than in s1
        }
    }
    return true; // All counts should be zero if they are anagrams
}