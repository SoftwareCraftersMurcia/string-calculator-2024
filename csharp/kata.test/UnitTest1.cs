using NSubstitute.ExceptionExtensions;

namespace kata.test;

//Example first test using xUnit, FluentAssertions and NSubistitute
//Commented things are only an example.
public class UnitTest1
{
    //Example Mock using NSubstitute
    //private readonly SomeController _sut; //sut is systemUnderTest, use the name that you want
    //private readonly ISomeService _someService = Substitute.For<ISomeService>();

    //Constructor is as StartUp
    public UnitTest1()
    {
        //Example using created mock
        //_sut = new SomeController(_someService);
    }

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
    public void IgnoreNumbersGreaterThan1000()
    {
        StringCalculator.Add("5,2,1000").Should().Be(1007);
        StringCalculator.Add("5,2,1001").Should().Be(7);
    }
}

public class StringCalculator
{
    static IEnumerable<char> InitialSeparators => new List<char> { ',', '\n' };

    public static int Add(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;
        if (!ContainsMultipleNumbers(input))
            return int.Parse(input);

        IdentifyNegativeNumbers(input);

        var result = 0;

        foreach (var number in input.Split(AllSeparatorsFrom(input).ToArray()))
        {
            if (!int.TryParse(number, out var parsed))
                continue;
            if (parsed > 1000)
                continue;

            result += parsed;
        }

        return result;
    }

    static void IdentifyNegativeNumbers(string input)
    {
        var negativeNumbers = new List<int>();

        foreach (var number in input.Split(AllSeparatorsFrom(input).ToArray()))
        {
            if (!int.TryParse(number, out var parsed))
                continue;

            if (parsed < 0)
                negativeNumbers.Add(parsed);
        }

        if (negativeNumbers.Count > 0)
            throw new ArgumentException(string.Join(',', negativeNumbers));
    }

    static bool ContainsMultipleNumbers(string input)
        => input.Contains(',') || input.Contains('\n') || input.Contains("//");

    static IEnumerable<char> AllSeparatorsFrom(string input)
        => input.Contains("//") ? InitialSeparators.Append(input[2]) : InitialSeparators;
}
