function isDateInRange(day, month) {
   month = month.toLowerCase();
   if (
        (month === 'march' && day >= 20 && day <= 31) || 
        (month === 'april' && day >= 1 && day <= 30) || 
        (month === 'may' && day >= 1 && day <= 31) || 
        (month === 'june' && day >= 1 && day <= 20)
    ) {
        return true;
    } else {
        return false;
    }
}

const day = parseInt(process.argv[2]);
const month = process.argv[3];

if (!isNaN(day) && month) {
    console.log(isDateInRange(day, month));
} else {
    console.log("Please provide a valid day and month. Example: node dateCheck.js 21 march");
}