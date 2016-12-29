// Problem 8: Trapezoids

function solve(args) {
	var a = +args[0];
	var b = +args[1];
	var h = +args[2];
	var result = (0.5 * (a + b) * h).toFixed(7);
	return result;
}