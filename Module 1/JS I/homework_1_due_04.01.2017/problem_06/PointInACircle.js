// Problem 6. Point In A Circle

function solve(args) {
var x = +args[0],
    y = +args[1],
    distance = Math.sqrt(x * x + y * y),
	isInCircle = (distance <= 2),
	result = (isInCircle ? "yes " : "no ") + distance.toFixed(2);
return result;
}