// Problem 5. Third Bit - BGCoder format
function solve(args) {
	var n = +args[0];
    var nBase2 = '000' + n.toString(2);
    var result = nBase2.slice(-4, -3);
	return result;
}