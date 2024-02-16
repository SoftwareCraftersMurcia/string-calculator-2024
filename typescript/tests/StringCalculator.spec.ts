import { StringCalculator } from "../src/StringCalculator"

describe('StringCalculator', () => {
  it('should return 0 for empty string', () => {
    const strCalc = new StringCalculator()

    expect(strCalc.add("")).toBe(0)
  })
})

