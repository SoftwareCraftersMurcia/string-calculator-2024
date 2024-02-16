<?php declare(strict_types=1);

namespace Kata;

class StringCalculator
{
    public function add(string $value): int
    {
        $numbers = explode(',', str_replace("\n", ",", $value));

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
}
