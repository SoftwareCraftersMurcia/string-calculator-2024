export class StringCalculator {
  add(numbers: string): number {
    if (numbers === "") return 0;
    
    const parts = numbers.split(",");

    
    if (parts.length > 2) {
      const nums = parts.map(val => +val);
      const sum = nums.reduce((acc, current)=>{
        return acc + current;
      }, 0)
      return sum;
    }

    if (parts.length > 1) return +parts[0] + +parts[1];
    return +numbers;
  }
}
