using System.Runtime.Serialization;
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
    public void LongerSeparators()
    {
        StringCalculator.Add("//[*]\n5*2").Should().Be(5 + 2);
        StringCalculator.Add("//[**]\n5**3").Should().Be(5 + 3);
        StringCalculator.Add("//[*&*]\n2*&*3").Should().Be(2 + 3);
        StringCalculator.Add("//[&&&&]\n2&&&&5").Should().Be(2 + 5);
        StringCalculator.Add("//[&&]\n2&&5&&4").Should().Be(2 + 5 + 4);
    }

    [Fact]
    public void MultipleSeparators_OfLengthOne()
    {
        StringCalculator.Add("//[&][*]\n2&5*4").Should().Be(2 + 5 + 4);
    }

    [Fact]
    public void MultipleSeparators_OfArbitraryLength()
    {
        StringCalculator.Add("//[&&&][**]\n2&&&5**4").Should().Be(2 + 5 + 4);
        StringCalculator.Add("//[&][**]\n2&6**4").Should().Be(2 + 6 + 4);
    }

    [Fact]
    public void ContentOfMultipleSeparators()
    {
        StringCalculator.AllContentsOf("[&][*]").Should().Contain("&").And.Contain("*");
        StringCalculator.AllContentsOf("[&&][***]").Should().Contain("&&").And.Contain("***");
    }

    [Fact]
    public void ContentOfSeparator()
    {
        StringCalculator.ContentOf("[*]").Should().Be("*");
        StringCalculator.ContentOf("[**]").Should().Be("**");
    }
}
