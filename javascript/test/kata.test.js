const { StringCalculator } = require('../src/kata');

describe("Kata string-calculator", function () {
  it("should add the given numbers", function () {
    const calculator = new StringCalculator()
    var result = calculator.add("");
      expect(result).toBe(0);
  });
});
