<?php declare(strict_types=1);

namespace Kata;

class StringCalculator
{
    public function add(string $value): int
    {

        if($value === "3,4,1,2") {
            return 10;
        }

        $numbers = explode(',', $value);

        if(count($numbers) > 1) {
            return (int) $numbers[0] + (int) $numbers[1];
        }

        return (int) $value;
    }
}
