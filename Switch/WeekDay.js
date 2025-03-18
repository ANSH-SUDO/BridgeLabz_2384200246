function getWeekDay(number) {
    switch (number) {
        case 1: return "Sunday";
        case 2: return "Monday";
        case 3: return "Tuesday";
        case 4: return "Wednesday";
        case 5: return "Thursday";
        case 6: return "Friday";
        case 7: return "Saturday";
        default: return "Please enter a number between 1 and 7";
    }
}

const number = parseInt(process.argv[2]);

if (!isNaN(number)) {
    console.log(getWeekDay(number));
} else {
    console.log("Please provide a valid number. Example: node weekDay.js 3");
}