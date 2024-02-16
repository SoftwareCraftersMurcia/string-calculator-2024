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
    public function given_4_value_then_return_4(): void
    {
        $stringCalculator = new StringCalculator();

        $result = $stringCalculator->add("4");

        self::assertEquals(4, $result);
    }

    /** @test */
    public function given_5_value_then_return_5(): void
    {
        $stringCalculator = new StringCalculator();

        $result = $stringCalculator->add("5");

        self::assertEquals(5, $result);
    }

    /** @test */
    public function given_6_value_then_return_6(): void
    {
        $stringCalculator = new StringCalculator();

        $result = $stringCalculator->add("6");

        self::assertEquals(6, $result);
    }
}
