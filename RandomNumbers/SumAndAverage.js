function generateRandomTwoDigitNumber() {
    return Math.floor(Math.random() * 90) + 10;
}

function calculateSumAndAverage() {
let sum = 0;
let numbers = [];

for (let i = 0; i < 5; i++) {
   let num = generateRandomTwoDigitNumber();
   numbers.push(num);
   sum += num;
}

let average = sum / numbers.length;
console.log(sum);
console.log(average);