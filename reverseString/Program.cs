string input = "My name is shashi";

string reversed = ReverseString(input);

string ReverseString(string str)
{
    // char[] charArray = str.ToCharArray();
    // Array.Reverse(charArray);
    // return new string(charArray);


    // char[] charArray = str.ToCharArray();
    // string reversed = string.Empty;
    // for (int i = charArray.Length - 1; i >= 0; i--)
    // {
    //     reversed += charArray[i];
    // }

    char[] reversed = str.ToCharArray().Reverse().ToArray();
    return new string(reversed);
}

Console.WriteLine(reversed);
Console.ReadLine();
