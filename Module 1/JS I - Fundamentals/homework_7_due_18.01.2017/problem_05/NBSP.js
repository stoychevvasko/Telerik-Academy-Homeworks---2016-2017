// Problem 05. NBSP - BGCoder format
function solve(args) {
	let fullString = args[0],
		result = fullString.split(' ').join('&nbsp;');		
	
	return result;
}