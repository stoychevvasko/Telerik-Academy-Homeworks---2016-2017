// Problem 03: Sub-string in text - BGCoder format
function solve(args) {
	let item = args[0].toLowerCase(),
		text = args[1].toLowerCase(),
		result = text.split(item).length - 1;
	
	if (result < 0) {
		result = 0;
	}	
	
	return result;
}