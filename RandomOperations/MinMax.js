function generateRandomThreeDigitNumber() {
    return Math.floor(Math.random() * 900) + 100;
}

function findMinMax() {
    let numbers = [];

    for (let i = 0; i < 5; i++) {
        numbers.push(generateRandomThreeDigitNumber());
    }

    let min = Math.min(...numbers);
    let max = Math.max(...numbers);

    console.log(`Random numbers: ${numbers.join(', ')}`);
    console.log(`Minimum value: ${min}`);
    console.log(`Maximum value: ${max}`);
}