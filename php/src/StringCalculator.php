<?php declare(strict_types=1);

namespace Kata;

class StringCalculator
{
    public function add(string $value): int
    {
        $value = str_replace("\n", ',', $value);

        $numbers = explode(',', $value);

        if (count($numbers) == 0 || count($numbers) == 1) {
            return (int) $value;
        }

        $num = 0;

        foreach($numbers as $number) {
            $num += (int) $number;
        }

        return $num;

    }
}
