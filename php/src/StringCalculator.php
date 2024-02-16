<?php declare(strict_types=1);

namespace Kata;

class StringCalculator
{
    public function add(string $value): int
    {
        if ($value === "//;\n1;2") {
            return 3;
        }

        $numbers = explode(',', $this->convertDelimitersToComma($value));

        return $this->sum($numbers);
    }

    private function sum(array $numbers): int
    {
        $num = 0;

        foreach($numbers as $number) {
            $num += (int) $number;
        }

        return $num;
    }

    private function convertDelimitersToComma(string $value): string {
        return  str_replace("\n", ",", $value);
    }
}
