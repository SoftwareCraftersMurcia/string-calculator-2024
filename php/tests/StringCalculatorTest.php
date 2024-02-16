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

        $result = $stringCalculator->add("1,2");

        self::assertEquals(3, $result);
    }
}
