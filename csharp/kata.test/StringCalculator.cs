namespace kata.test;

public class StringCalculator
{
    static IEnumerable<string> InitialSeparators => new List<string> { ",", "\n" };

    public static int Add(string input)
    {
        EnsureNoNegativeNumbers(input);

        if (string.IsNullOrEmpty(input))
            return 0;
        if (!ContainsMultipleNumbers(input))
            return int.Parse(input);

        return input.Split(AllSeparatorsFrom(input).ToArray(), StringSplitOptions.None)
            .Select(Parsed)
            .Sum();
    }

    static int Parsed(string toBeParsed)
    {
        if (!int.TryParse(toBeParsed, out var parsed))
            return 0;
        if (parsed > 1000)
            return 0;

        return parsed;
    }

    static void EnsureNoNegativeNumbers(string input)
    {
        var negativeNumbers = input.Split(AllSeparatorsFrom(input).ToArray(), StringSplitOptions.None).Select(Parsed)
            .Where((n) => n < 0);

        if (!negativeNumbers.Any())
            return;

        throw new ArgumentException(string.Join(',', negativeNumbers));
    }

    static bool ContainsMultipleNumbers(string input)
        => input.Contains(',') || input.Contains('\n') || input.Contains("//");

    static IEnumerable<string> AllSeparatorsFrom(string input)
    {
        if (!input.Contains("//"))
            return InitialSeparators;

        if (input.Contains('['))
            return InitialSeparators
                .Append(ContentOf(input.Split('\n')[0].Remove(0, 2)));

        return InitialSeparators.Append(input[2].ToString());
    }

    public static string ContentOf(string separator)
        => separator.Remove(separator.Length - 1, 1).Remove(0, 1);

    public static IEnumerable<string> AllContentsOf(string separators)
        => separators.Split(']')
            .Select(x => x + ']')
            .SkipLast(1)
            .Select(ContentOf);
}
