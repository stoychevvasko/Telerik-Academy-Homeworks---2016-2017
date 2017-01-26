/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function solve() {
	function isPrime(number) {
			for (let i = 2; i < number; i += 1) {
				if ((number % i) === 0) {					
					return false;
				}
			}

			return true;
		}

	return function findPrimes() {
		if (arguments === null || arguments.length < 2) {
			throw "Error";
		}

		let primes = [];

		for (let j = (+arguments[0][0]); j <= (+arguments[0][1]); j += 1) {
			if (isPrime(j)) {
				primes.push(j);
			}
		}

		return primes;
	}
}

module.exports = solve;
