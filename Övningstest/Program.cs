using System;
using System.Linq;

public class StringManipulator
{
    public string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public int CountVowels(string input)
    {
        return input.Count(c => "aeiouAEIOU".Contains(c));
    }

    public string ConcatenateStrings(string str1, string str2)
    {
        return $"{str1} {str2}";
    }
}
