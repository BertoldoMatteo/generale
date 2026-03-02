using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"^flag\{[\D]{2}[0][a-z][^0-9][L][\w]{4}[^a-pr-z]{3}[^\d]{2}[\d][b]\}$";
        string input = @"";
        RegexOptions options = RegexOptions.Multiline | RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.IgnorePatternWhitespace;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
        }
    }
}