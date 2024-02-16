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
}
