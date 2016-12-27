// Problem 2: Divide by 7 and 5

function solve(args) {
    var n = +args[0];
    var isDivisible = (n % 7 === 0 && n % 5 === 0);
    var result = isDivisible + ' ' + n;    
	return result;
}