using NSubstitute.ExceptionExtensions;

namespace kata.test;

//Example first test using xUnit, FluentAssertions and NSubistitute
//Commented things are only an example.
// https://github.com/SoftwareCraftersMurcia/string-calculator-2024 <-- The kata
public class UnitTest1
{
    [Fact]
    public void EmptyString_ReturnsZero()
    {
        StringCalculator.Add("").Should().Be(0);
    }

    [Fact]
    public void StringWithSingleNumber_ReturnsTheNumber()
    {
        StringCalculator.Add("1").Should().Be(1);
    }

    [Fact]
    public void SumTwoNumber_SepareteByCommas()
    {
        StringCalculator.Add("1,2").Should().Be(3);
    }

    [Fact]
    public void SumTwoNumbers_WithMoreThanOneDigit()
    {
        StringCalculator.Add("10,2").Should().Be(12);
    }

    [Fact]
    public void Sum_MoreThanTwoNumbers()
    {
        StringCalculator.Add("10,2,5").Should().Be(17);
        StringCalculator.Add("7,5,20,8").Should().Be(40);
    }

    [Fact]
    public void identify_Scape_Character_as_separator()
    {
        StringCalculator.Add("1\n8").Should().Be(9);
    }

    [Fact]
    public void Sum_Numbers_Different_separators()
    {
        StringCalculator.Add("1\n9,2").Should().Be(12);
    }

    [Fact]
    public void Include_Separators_Custom()
    {
        StringCalculator.Add("//;\n1;2").Should().Be(3);
        StringCalculator.Add("//;\n1;4").Should().Be(5);
        StringCalculator.Add("//;\n1;2,4").Should().Be(7);
    }

    [Fact]
    public void ThrowExceptionWhenAttemptingToAddNegativeNumbers()
    {
        try
        {
            StringCalculator.Add("-1,5,-4");
            Assert.False(true);
        }
        catch (ArgumentException ex)
        {
            ex.Message.Should().Be("-1,-4");
        }
    }

    [Fact]
    public void ThrowException_SingleNumber_Negative()
    {
        try
        {
            StringCalculator.Add("-1");
            Assert.False(true);
        }
        catch (ArgumentException ex)
        {
            ex.Message.Should().Be("-1");
        }
    }

    [Fact]
    public void IgnoreNumbersGreaterThan1000()
    {
        StringCalculator.Add("5,2,1000").Should().Be(1007);
        StringCalculator.Add("5,2,1001").Should().Be(7);
    }

    [Fact]
    public void asfafasfsa()
    {
        StringCalculator.Add("//[*]\n5*2").Should().Be(5 + 2);
    }
}

public class StringCalculator
{
    static IEnumerable<char> InitialSeparators => new List<char> { ',', '\n' };

    public static int Add(string input)
    {
        EnsureNoNegativeNumbers(input);

        if (string.IsNullOrEmpty(input))
            return 0;
        if (!ContainsMultipleNumbers(input))
            return int.Parse(input);

        return input.Split(AllSeparatorsFrom(input).ToArray())
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
        var negativeNumbers = input.Split(AllSeparatorsFrom(input).ToArray()).Select(Parsed).Where((n) => n < 0);

        if (!negativeNumbers.Any())
            return;

        throw new ArgumentException(string.Join(',', negativeNumbers));
    }

    static bool ContainsMultipleNumbers(string input)
        => input.Contains(',') || input.Contains('\n') || input.Contains("//");

    static IEnumerable<char> AllSeparatorsFrom(string input)
    {
        if (!input.Contains("//"))
            return InitialSeparators;

        if (input.Contains("[*]"))
            return InitialSeparators.Append('*');

        return InitialSeparators.Append(input[2]);
    }
}
