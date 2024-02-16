class StringCalculator {
  add(numbers) {
    if (numbers === '') {
      return 0
    }

    const elements = this.#splitElements(numbers)

    const elmentsNumbers = this.#convertToNumbers(elements)

    return this.#sumElements(elmentsNumbers)
  }

  #splitElements(numbers) {
    return numbers.split(',')
  }

  #convertToNumbers(elements) {
    return elements.map((element) => Number(element))
  }

  #sumElements(elements) {
    return elements.reduce((acumulator, element) => {
        return acumulator + element
      })
  }
}

module.exports = {StringCalculator};
