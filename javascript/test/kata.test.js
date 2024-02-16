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

  describe('given a set of numbers it should return the sum of them', () => {
    it('1 + 2', () => {
      const calculator = new StringCalculator()
      var result = calculator.add('1,2')
      expect(result).toBe(3)
    });

    it('2 + 2', () => {
      const calculator = new StringCalculator()
      var result = calculator.add('2,2')
      expect(result).toBe(4)
    });

    it('1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9', () => {
      const calculator = new StringCalculator()
      var result = calculator.add('1,2,3,4,5,6,7,8,9')
      expect(result).toBe(45)
    });
  })
});
