// Problem 3: The Biggest of Three - BGCoder format
function solve(args) {	
    var first = parseFloat(args[0]),
        second = parseFloat(args[1]),
        third = parseFloat(args[2]);

    if (first >= second) {
        if (first >= third) {
            return first;
        } else {
            return third;
        }
    } else if (second >= third) {
        return second;
    } else {
        return third;
    }
}