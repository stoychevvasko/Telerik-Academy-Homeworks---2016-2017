// Problem 06. First larger than neighbours - BGCoder format
function solve(args) {
	let count = +args[0],
		arr = args[1].split(' ').map(Number);
	
	function LargerThanNeighbours(arr, i) {		
		return ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1]));
	}
	
	function FirstAppearance(arr, len) {
		for (let i = 1; i < count; i += 1) {
			if (LargerThanNeighbours(arr, i)) {
				return i;
			}
		}
		
		return -1;
	}
	
	let result = FirstAppearance(arr, count);	
	return (result);
}