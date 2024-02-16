export class StringCalculator {
  add(numbers: string): number {
    if (numbers === "") return 0;
    
    const parts = numbers.split(",");

    const nums = parts.map(val => +val);
    const sum = nums.reduce((acc, current)=>{
      return acc + current;
    }, 0)
    return sum;
  }
}
