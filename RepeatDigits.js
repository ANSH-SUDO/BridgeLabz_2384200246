function findRepeatedDigitsInRange(start, end) {
    let repeatedDigits = [];

    for (let i = start; i <= end; i++) {
        // Convert the number to a string and check if both digits are the same
        let strNum = i.toString();
        if (strNum.length === 2 && strNum[0] === strNum[1]) {
            repeatedDigits.push(i);
        }
    }

    return repeatedDigits;
}

const repeatedDigits = findRepeatedDigitsInRange(0, 100);

console.log("Repeated digit numbers in the range 0 to 100:", repeatedDigits);
