const numbers = Array.from({ length: 10 }, () => Math.floor(Math.random() * 900) + 100);

console.log("Generated Numbers:", numbers);

function findSecondLargestAndSmallest(arr) {
    let largest = -Infinity, secondLargest = -Infinity;
    let smallest = Infinity, secondSmallest = Infinity;

    for (let num of arr) {
        if (num > largest) {
            secondLargest = largest;
            largest = num;
        } else if (num > secondLargest && num !== largest) {
            secondLargest = num;
        }

        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num !== smallest) {
            secondSmallest = num;
        }
    }

    return {
        secondLargest,
        secondSmallest
    };
}

const { secondLargest, secondSmallest } = findSecondLargestAndSmallest(numbers);

console.log("Second Largest (without sorting):", secondLargest);
console.log("Second Smallest (without sorting):", secondSmallest);

const sortedNumbers = [...numbers].sort((a, b) => a - b);

console.log("\nSorted Numbers:", sortedNumbers);

const sortedSecondSmallest = sortedNumbers[1];
const sortedSecondLargest = sortedNumbers[sortedNumbers.length - 2];

console.log("Second Smallest (sorted):", sortedSecondSmallest);
console.log("Second Largest (sorted):", sortedSecondLargest);
