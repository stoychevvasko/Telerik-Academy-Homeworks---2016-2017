// Problem 04. Appearance Count - BGCoder format
function solve(args) {
	let count = +args[0],
		arr = args[1].split(' ').map(Number),
		element = +args[2];
	
	function CountAppearances(arr, val) {
		let result = 0,
			len = arr.length;
		
		for (let i = 0; i < len; i += 1) {
			if (arr[i] === element) {
				result += 1;
			}
		}
		
		return result;
	}
	
	let result = CountAppearances(arr, element);		
	return (result);
}