function rollDie() {
    return Math.floor(Math.random() * 6) + 1;
}

function simulateDiceRolls() {
    let rollResults = { 1: 0, 2: 0, 3: 0, 4: 0, 5: 0, 6: 0 };
    let maxRolls = 10;
    let reachedLimit = false;

    while (!reachedLimit) {
        let roll = rollDie(); // Roll the die
        rollResults[roll]++; // Update the count in the dictionary

        // Check if any number reached the limit of 10 times
        if (rollResults[roll] === maxRolls) {
            reachedLimit = true;
        }
    }

    console.log("Final roll counts:", rollResults);

    // Find the number that appeared the most and the least
    let maxNumber = Object.keys(rollResults).reduce((a, b) => rollResults[a] > rollResults[b] ? a : b);
    let minNumber = Object.keys(rollResults).reduce((a, b) => rollResults[a] < rollResults[b] ? a : b);

    console.log(`Number that reached maximum times: ${maxNumber} (${rollResults[maxNumber]} times)`);
    console.log(`Number that reached minimum times: ${minNumber} (${rollResults[minNumber]} times)`);
}

simulateDiceRolls();
