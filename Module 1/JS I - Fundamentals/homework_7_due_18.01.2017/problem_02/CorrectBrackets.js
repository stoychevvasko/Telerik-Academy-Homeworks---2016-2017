// Problem 02: Correct brackets - BGCoder format
function solve(args) {
	let fullString = args[0],
		len = fullString.length,
		result = 'invalid_result';
	
	function evaluateBrackets(str) {
		if ((str.split('(').length) === (str.split(')').length)) {
			return true;
		}		
		
		return false;
	}
	
	result = (evaluateBrackets(fullString) ? 'Correct' : 'Incorrect');
	return result;
}