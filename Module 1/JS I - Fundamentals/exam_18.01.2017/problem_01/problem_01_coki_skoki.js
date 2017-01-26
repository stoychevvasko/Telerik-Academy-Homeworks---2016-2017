function solve(args) {
	let input = args.map(Number),
	n = +input[0],
	numbers = [],
	result = 0;
	
	for (let i = 1; i <= n; i += 1) {
		numbers.push(+args[i]);
	}
	
	function isOdd(num) {
		if (num & 1 === 1) {
			return true;
		}	
		
		return false;
	}		
	
	for (let i = 0; i < n; i += 1) {
		if (isOdd(numbers[i])) {
			// odd
			if (result === 0) {
				result = 1;
			}
			result *= parseFloat(numbers[i]);			
		} else {
			// even
			result += parseFloat(numbers[i]);
			i += 1;
		}
		
		result = (result & 1023);
	}
	
	return result;
}

console.log(solve(
[
  '10',
  '1',
  '2',
  '3',
  '4',
  '5',
  '6',
  '7',
  '8',
  '9',
  '0'
]
));

// 21

console.log(solve(
[
  '9',
  '9',
  '9',
  '9',
  '9',
  '9',
  '9',
  '9',
  '9',
  '9'
]
));

// 329