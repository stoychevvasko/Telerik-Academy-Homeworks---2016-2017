// Problem 1: Odd or Even - BGCoder format
function solve(args) {
	var n = +args[0];
    var result = ((n % 2) === 0) ? ('even ' + n) : ('odd ' + n);    
    return result;
}


