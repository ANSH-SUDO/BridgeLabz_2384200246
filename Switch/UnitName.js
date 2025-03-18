function getUnitName(number) {
    switch (number) {
        case 1: return "Unit";
        case 10: return "Ten";
        case 100: return "Hundred";
        case 1000: return "Thousand";
        case 10000: return "Ten Thousand";
        case 100000: return "Lakh";
        case 1000000: return "Million";
        default: return "Please enter a valid number (1, 10, 100, 1000, ...)";
    }
}

// Get input from the command line
const number = parseInt(process.argv[2]);

if (!isNaN(number)) {
    console.log(getUnitName(number));
} else {
    console.log("Please provide a valid number. Example: node numberUnit.js 100");
}

