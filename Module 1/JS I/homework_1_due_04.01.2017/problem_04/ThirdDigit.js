// Problem 4. Third Digit - BGCoder format
function solve(args) {
	var n = args[0];
    var thirdDigit = (n.slice(-3, -2) === '') ? '0' : n.slice(-3, -2);
    var result = (thirdDigit === '7') ? 'true' : ('false ' + thirdDigit);
	return result;
}