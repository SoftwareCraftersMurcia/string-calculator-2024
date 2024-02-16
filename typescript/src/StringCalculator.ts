export class StringCalculator {
  add(numbers: string): number {
    if (numbers === "") return 0;
    const parts = numbers.split(",");
    if (parts.length > 1) return +parts[0] + +parts[1];
    return +numbers;
  }
}
