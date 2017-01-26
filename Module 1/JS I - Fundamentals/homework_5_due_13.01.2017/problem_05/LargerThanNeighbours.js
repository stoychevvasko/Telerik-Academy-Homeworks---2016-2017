// Problem 05. Larger than Neighbours - BGCoder format
function solve(args) {
	let count = +args[0],
		arr = args[1].split(' ').map(Number);
	
	function LargerThanNeighbours(arr, i) {
		return ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1]));
	}
	
	function CountAppearances(arr, len) {
		let result = 0;
		
		for (let i = 1; i < count; i += 1) {
			if (LargerThanNeighbours(arr, i)) {
				result += 1;
			}
		}
		
		return (result);
	}
	
	let result = CountAppearances(arr, count);
	
	return (result);
}