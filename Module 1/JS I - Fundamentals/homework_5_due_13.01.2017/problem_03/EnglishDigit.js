// Problem 03: English Digit
function solve(args) {
	let num = +args;	
	
	function LastDigitAsWord(integer) {
		let numberAsString = integer.toString(),
			lastIndex = numberAsString.length - 1,
			lastCharacter = numberAsString[lastIndex];
		
		switch (lastCharacter) {
			case `0`:
				return `zero`;
			case `1`:
				return `one`;
			case `2`:
				return `two`;
			case `3`:
				return `three`;
			case `4`:
				return `four`;
			case `5`:
				return `five`;
			case `6`:
				return `six`;
			case `7`:
				return `seven`;
			case `8`:
				return `eight`;
			case `9`:
				return `nine`;
			default: 
				return `invalid digit ${lastCharacter}`;
		}
	}
	
	let result = LastDigitAsWord(num);	
	return (result);
}