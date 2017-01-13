// Problem 06. First larger than neighbours - BGCoder format
function solve(args) {
	let count = +args[0],
		arr = args[1].split(' ').map(Number);
	
	function FirstAppearance(arr, len) {
		for (let i = 1; i < count; i += 1) {
			if ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1])) {
				return i;
			}
		}
		
		return -1;
	}
	
	let result = FirstAppearance(arr, count);	
	return (result);
}