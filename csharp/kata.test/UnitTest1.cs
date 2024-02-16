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
    public void fksndtny()
    {
        StringCalculator.Add("1\n8").Should().Be(9);
    }
}

public class StringCalculator
{
    public static int Add(string empty)
    {
        if (!string.IsNullOrEmpty(empty))
        {
            if (empty.Contains(',') || empty.Contains('\n'))
            {
                return empty.Split(',', '\n').Sum(int.Parse);
            }

            return int.Parse(empty);
        }

        return 0;
    }
}
