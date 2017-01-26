/* Task 1. */ 
/*   Write a function that sums an array of numbers:
	Numbers must be always of type Number
	Returns null if the array is empty
	Throws Error if the parameter is not passed (undefined)
	Throws if any of the elements is not convertible to Number
*/

function solve() {
	return function sum() {
		if (arguments === null) {
			throw "Error";
		}	

		let arr = [].slice.call(arguments[0]);

		if (arr.length === 0) {
			return null;
		}

		let result = arr.reduce((a, b) => (+a) + (+b), 0);

		if (isNaN(result)) {
			throw "Error";
		}

		return result;
	}
}

module.exports = solve;
