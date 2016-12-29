// Problem 1: Exchange If Greater - BGCoder format
function solve(args) {
	var a = +args[0],
		b = +args[1];
		
	if (a > b) { 
		return (b + ' ' + a); 
	} else {
		return (a + ' ' + b);
	}
}