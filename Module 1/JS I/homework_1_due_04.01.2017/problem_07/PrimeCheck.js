// Problem 7: Prime Check - BGCoder format
function solve(args) {
    var n = +args[0];
    var isPrime = (n > 1);
    var i = 2;
    while (i <= Math.sqrt(n)) {
        if (n % i++ < 1) isPrime = false;
    }
    return isPrime;
}