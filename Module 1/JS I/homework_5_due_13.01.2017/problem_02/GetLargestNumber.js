// Problem 02: Get Largest Number - BGCoder format
function solve(args) {
	let numbers = args[0].split(' ').map(Number);
	
	function GetMax(first, second, third) {
		if ((first >= second) && (first >= third)) {
			return first;
		} else if ((second >= first) && (second >= third)) {
			return second;
		} else if ((third >= first) && (third >= second)) {
			return third;
		} else {
			return first;
		}
	}
	
	let result = GetMax(numbers[0], numbers[1], numbers[2]);		
	return (result);
}