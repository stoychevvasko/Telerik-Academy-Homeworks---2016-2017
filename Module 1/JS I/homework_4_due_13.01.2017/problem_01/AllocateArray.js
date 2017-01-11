// Problem 01. Increase array members - Allocate Array - BGCoder format
function solve(args) {	
	var n = +args, 
	result = "";
	for (let i = 0; i < n; i += 1) {
		result += ((i * 5) + "\n");
	}
	
	return result;
}