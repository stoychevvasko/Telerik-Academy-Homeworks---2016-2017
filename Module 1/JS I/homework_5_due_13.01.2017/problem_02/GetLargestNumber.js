// Problem 02: Get Largest Number - BGCoder format
function solve(args) {
	let numbers = args.split(' ').map(Number);
	
	function greatestOfThree(first, second, third) {
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
	
	let result = greatestOfThree(numbers[0], numbers[1], numbers[2]);		
	return (result);
}