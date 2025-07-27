string? input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Input cannot be null or empty.");
    return;
}

string? reversed = ReverseString(input);

string? ReverseString(string? str)
{
    if (str == null)
    {
        return null;
    }
    char[] reversed = str.ToCharArray().Reverse().ToArray();
    return new string(reversed);
}

if (reversed != null && reversed.Equals(input, StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine("The input is a palindrome.");
}
else
{
    Console.WriteLine("Input is not palindrome.");
}

