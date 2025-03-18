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

console.log("Second Largest:", secondLargest);
console.log("Second Smallest:", secondSmallest);
