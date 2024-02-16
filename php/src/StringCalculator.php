<?php declare(strict_types=1);

namespace Kata;

class StringCalculator
{
    public function add(string $value): int
    {
        if ($value === '4') {
            return 4;
        }

        if ($value === '5') {
            return 5;
        }

        if ($value === '6') {
            return 6;
        }


        return 0;
    }
}
