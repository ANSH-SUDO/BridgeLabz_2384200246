const lengthInMeters = lengthInFeet * 0.3048;
const widthInMeters = widthInFeet * 0.3048;

console.log(`Rectangular plot size: ${lengthInFeet} ft x ${widthInFeet} ft`);
console.log(`In meters: ${lengthInMeters.toFixed(2)} m x ${widthInMeters.toFixed(2)} m`);