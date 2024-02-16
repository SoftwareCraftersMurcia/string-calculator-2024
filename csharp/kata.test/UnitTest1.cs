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
}

public class StringCalculator
{
    public static int Add(string empty)
    {
        return 0;
    }
}
