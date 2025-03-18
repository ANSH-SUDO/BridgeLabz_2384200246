function isLeapYear(year) {
    if (year >= 1000 && year <= 9999) {
        if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)) {
            return `${year} is a Leap Year`;
        } else {
            return `${year} is NOT a Leap Year`;
        }
    } else {
        return "Please enter a valid 4-digit year";
    }
}

const year = parseInt(process.argv[2]);

if (!isNaN(year)) {
    console.log(isLeapYear(year));
} else {
    console.log("Please provide a valid year. Example: node leapYear.js 2024");
}