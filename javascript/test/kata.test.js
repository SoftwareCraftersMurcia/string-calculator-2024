const { StringCalculator } = require('../src/kata');

describe("Kata string-calculator", function () {
  it("should add the given numbers", function () {
    const calculator = new StringCalculator()
    var result = calculator.add("");
      expect(result).toBe(0);
  });

  it('given one number it should return it as the result', () => {
    const calculator = new StringCalculator()
    var result = calculator.add('4')
    expect(result).toBe(4)
  });

  it('given two numbers it should return the sum of them', () => {
    const calculator = new StringCalculator()
    var result = calculator.add('1,2')
    expect(result).toBe(3)
  });
});
