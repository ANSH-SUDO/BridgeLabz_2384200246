const areaInSquareFeet = lengthInFeet * widthInFeet;

const totalAreaInSquareFeet = areaInSquareFeet * numberOfPlots;

const totalAreaInAcres = totalAreaInSquareFeet / 43560;

console.log(totalAreaInAcres);