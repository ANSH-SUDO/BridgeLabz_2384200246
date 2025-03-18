function numberToWord(number) {
    switch (number) {
        case 0: return "Zero";
        case 1: return "One";
        case 2: return "Two";
        case 3: return "Three";
        case 4: return "Four";
        case 5: return "Five";
        case 6: return "Six";
        case 7: return "Seven";
        case 8: return "Eight";
        case 9: return "Nine";
        default: return "Please enter a single digit number (0-9)";
    }
}

const number = parseInt(process.argv[2]);

if (!isNaN(number)) {
    console.log(numberToWord(number));
} else {
    console.log("Please provide a valid single digit number. Example: node numberToWord.js 5");
}