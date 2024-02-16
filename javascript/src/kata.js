class StringCalculator {
  add(numbers) {
    if (numbers === '') {
      return 0
    }

    const sum = numbers.split(',').map((element) => Number(element)).reduce((acumulator, element) => {
      return Number(acumulator) + Number(element)
    })

    return sum
  }
}

module.exports = {StringCalculator};
