class StringCalculator {
  add(numbers) {
    if (numbers === '') {
      return 0
    }

    const sum = numbers.split(',').reduce((acumulator, element) => {
      return Number(acumulator) + Number(element)
    })

    return Number(sum)
  }
}

module.exports = {StringCalculator};
