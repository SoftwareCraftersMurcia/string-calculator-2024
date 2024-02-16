export class StringCalculator {
  add(numbers: string): number {
    if (numbers === "") return 0;

    return numbers.split(",")
      .map(val => +val)
      .reduce((acc, current) => acc + current, 0)
  }
}
