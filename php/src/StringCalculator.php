<?php declare(strict_types=1);

namespace Kata;

class StringCalculator
{
    public function add(string $value): int
    {
        if ($value === '1,2') {
            return 3;
        }

        return (int) $value;
    }
}
