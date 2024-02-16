import { StringCalculator } from "../src/StringCalculator";

describe("StringCalculator", () => {
  let strCalc: StringCalculator;
  
  beforeEach(() => {
    strCalc = new StringCalculator();
  })

  it("should return 0 for empty string", () => {
    expect(strCalc.add("")).toBe(0);
  });
  it("should return the numeric value of string with one number", () => {
    expect(strCalc.add("40")).toBe(40);
  });
  it("should return the sum of two numbers separated by comma", () => {
    expect(strCalc.add("1,2")).toBe(3);
  });

  it("should return the sum of any amount of numbers separated by comma", () => {
    expect(strCalc.add("1,2,3,4,5,6,7,8,9")).toBe(45);
  });
});
