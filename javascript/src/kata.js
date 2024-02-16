class StringCalculator {
  add(numbers) {
    if (numbers === '') {
      return 0
    }

    return Number(numbers.split(',').reduce((a, b) => {
      return Number(a) + Number(b)
    }))
  }
}

module.exports = {StringCalculator};
