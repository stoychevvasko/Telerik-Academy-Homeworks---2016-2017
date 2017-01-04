// Problem 01: Numbers from 1 to N - BGCoder format
function solve(args) {
	var n = +args[0],
		result = '';	
	for (let i = 1; i <= n; i += 1) {
		result += (i + ' ');
	}
	
	result = result.trim();	
	return (result);
}