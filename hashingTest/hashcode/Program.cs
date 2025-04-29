using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, 12345 World!";
        string pattern = @"\d+";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}