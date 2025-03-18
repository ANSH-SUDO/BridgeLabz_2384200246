function findMaxMin(a, b, c) {
   
    let result1 = a + b * c;
    let result2 = a % b + c;
    let result3 = c + a / b;
    let result4 = a * b + c;

    console.log(`Result of a + b * c = ${result1}`);
    console.log(`Result of a % b + c = ${result2}`);
    console.log(`Result of c + a / b = ${result3}`);
    console.log(`Result of a * b + c = ${result4}`);

    let max = Math.max(result1, result2, result3, result4);
    let min = Math.min(result1, result2, result3, result4);

    console.log(`Maximum result = ${max}`);
    console.log(`Minimum result = ${min}`);
}

const a = parseFloat(process.argv[2]);
const b = parseFloat(process.argv[3]);
const c = parseFloat(process.argv[4]);

if (!isNaN(a) && !isNaN(b) && !isNaN(c)) {
    findMaxMin(a, b, c);
} else {
    console.log("Please provide three valid numbers.");
}

