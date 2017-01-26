// Problem 3: Rectangles - BGCoder format
function solve(args) {
	var a = +args[0],
        b = +args[1];
    var perimeter = 2 * (a + b);
    var surface = a * b;
    var result = surface.toFixed(2) + ' ' + perimeter.toFixed(2);
    return result;
}