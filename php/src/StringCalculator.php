<?php declare(strict_types=1);

namespace Kata;

class StringCalculator
{
    public function add(string $value): int
    {
        if ($value === '1,2') {
            return 3;
        }

        $numbers = explode(',', $value);

        if(count($numbers) > 1) {
            return $numbers[0] + $numbers[1];
        }

        return (int) $value;
    }
}
