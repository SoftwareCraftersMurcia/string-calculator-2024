<?php declare(strict_types=1);

namespace Kata;

class StringCalculator
{
    public function add(string $value): int
    {
        $numbers = explode(',', $value);

        if(count($numbers) > 1) {
            return (int) $numbers[0] + (int) $numbers[1];
        }

        return (int) $value;
    }
}
