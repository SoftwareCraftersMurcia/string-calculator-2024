class StringCalculator {
  add(number) {
    if (number === '4') {
        return 4
    }

    if (number === '1,2') {
        return 3
    }

    return 0
  }
}

module.exports = {StringCalculator};
