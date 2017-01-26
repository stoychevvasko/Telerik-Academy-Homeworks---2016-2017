// Problem 01: Reverse string - BGCoder format
function solve(args) {
	let arr = args[0],
		len = arr.length,
		result = '';	
		
	for (let i = 0; i < len; i += 1) {
		result = ((arr[i]) + result);
	}	
	
	return result;
}