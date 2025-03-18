function generateBirthdays() {
    let birthdays = {};
    
    // Initialize the dictionary for months (1 to 12)
    for (let i = 1; i <= 12; i++) {
        birthdays[i] = [];
    }

    // Generate birthdays for 50 individuals
    for (let i = 1; i <= 50; i++) {
        let year = Math.random() < 0.5 ? 1992 : 1993; // Randomly choose year between 92 and 93
        let month = Math.floor(Math.random() * 12) + 1; // Random month between 1 and 12
        birthdays[month].push(`Person ${i} (Year: ${year})`);
    }

    return birthdays;
}

function displayBirthdays(birthdays) {
    console.log("Individuals having birthdays in the same month:");
    for (let month in birthdays) {
        if (birthdays[month].length > 0) {
            console.log(`Month ${month}: ${birthdays[month].join(", ")}`);
        }
    }
}

// Generate and display birthdays
let birthdays = generateBirthdays();
displayBirthdays(birthdays);
