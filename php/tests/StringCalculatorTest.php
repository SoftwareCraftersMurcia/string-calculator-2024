<?php declare(strict_types=1);

namespace KataTests;

use Kata\StringCalculator;
use PHPUnit\Framework\TestCase;

class StringCalculatorTest extends TestCase
{
    /** @test */
    public function given_empty_value_return_0(): void
    {
        $stringCalculator = new StringCalculator();

        $result = $stringCalculator->add("");

        self::assertEquals(0, $result);
    }

    /** @test */
    public function given_unique_value_then_return_its_self(): void
    {
        $stringCalculator = new StringCalculator();

        $result = $stringCalculator->add("4");

        self::assertEquals(4, $result);
    }

    /** @test */
    public function given_two_values_then_return_its_sum(): void
    {
        $stringCalculator = new StringCalculator();

        $result = $stringCalculator->add("3,4");

        self::assertEquals(7, $result);
    }

    /** @test */
    public function given_four_values_then_return_its_sum(): void
    {
        $stringCalculator = new StringCalculator();

        $result = $stringCalculator->add("3,4,1,2");

        self::assertEquals(10, $result);
    }

    /** @test */
    public function given_arbitrary_values_then_return_its_sum(): void
    {
        $stringCalculator = new StringCalculator();

        $result = $stringCalculator->add("3,4,1,2,4");

        self::assertEquals(14, $result);
    }

    /** @test */
    public function given_one_line_break_delimiter_then_return_its_sum(): void
    {
        $stringCalculator = new StringCalculator();

        $result = $stringCalculator->add("1\n2,3");

        self::assertEquals(6, $result);
    }
}
