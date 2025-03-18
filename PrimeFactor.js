function primeFactorization(n) {
    let factors = [];

    // Check for the number of times 2 divides n
    while (n % 2 === 0) {
        factors.push(2);
        n = n / 2;
    }

    // Check for odd factors starting from 3
    for (let i = 3; i * i <= n; i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n = n / i;
        }
    }

    // If n is still greater than 2, it must be prime
    if (n > 2) {
        factors.push(n);
    }

    return factors;
}

const number = 315; // We can change this value
const primeFactors = primeFactorization(number);

console.log(`Prime Factors of ${number} are:`, primeFactors);
