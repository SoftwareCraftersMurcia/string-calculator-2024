import { StringCalculator } from "../src/StringCalculator"

describe('StringCalculator', () => {
  it('should return 0 for empty string', () => {
    const strCalc = new StringCalculator()

    expect(strCalc.add("")).toBe(0)
  })
  it('should return the numeric value of string with one number', () => {
    const strCalc = new StringCalculator()

    expect(strCalc.add("40")).toBe(40)
  })
})
