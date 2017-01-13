function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestSayHello('P01_I01', 'P01_O01', 'P01_A01');
	console.log('===============================================');
	runTestGetLargestNumber('P02_I01', 'P02_O01', 'P02_A01');
	runTestGetLargestNumber('P02_I02', 'P02_O02', 'P02_A02');	
	console.log('===============================================');
	runTestEnglishDigit('P03_I01', 'P03_O01', 'P03_A01');
	console.log('===============================================');
	runTestAppearanceCount('P04_I01', 'P04_O01', 'P04_A01');
	console.log('===============================================');
	runTestLargerThanNeighbours('P05_I01', 'P05_O01', 'P05_A01');
	console.log('===============================================');
}

function convertToJSON(args) {	
	var input = args;
    var rawJSON = '[' + input.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(rawJSON);
	return arr;
}

// Problem 01: Say Hello
function sayHello(args) {	
	let name = args;
	
	function sayHello(name) {
		return (`Hello, ${name}!`);
	}
	
	let result = sayHello(name);
		
	console.log('Problem 01:\n' + result);
	return (result);
}

function runTestSayHello(input, output, actual) {
	document.getElementById(actual).innerHTML = sayHello(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 02: Get Largest Number
function getLargestNumber(args) {
	let numbers = args.split(' ').map(Number);
	
	function GetMax(first, second, third) {
		if ((first >= second) && (first >= third)) {
			return first;
		} else if ((second >= first) && (second >= third)) {
			return second;
		} else if ((third >= first) && (third >= second)) {
			return third;
		} else {
			return first;
		}
	}
	
	let result = GetMax(numbers[0], numbers[1], numbers[2]);
	
	console.log('Problem 02:\n' + result);
	return (result);
}

function runTestGetLargestNumber(input, output, actual) {
	document.getElementById(actual).innerHTML = getLargestNumber(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 03: English Digit
function englishDigit(args) {
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
	console.log('Problem 03:\n' + result);
	return (result);
}

function runTestEnglishDigit(input, output, actual) {
	document.getElementById(actual).innerHTML = englishDigit(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 04. Appearance Count
function appearanceCount(args) {
	let lines = args.split('<br>'),
		count = +lines[0],
		arr = lines[1].split(' ').map(Number),
		element = +lines[2],
		result = ``;
	
	function CountAppearances(arr, val) {
		let result = 0,
			len = arr.length;
		
		for (let i = 0; i < len; i += 1) {
			if (arr[i] === element) {
				result += 1;
			}
		}
		
		return result;
	}
	
	result = CountAppearances(arr, element);
	
	console.log('Problem 04:\n' + result);
	return (result);
}

function runTestAppearanceCount(input, output, actual) {
	document.getElementById(actual).innerHTML = appearanceCount(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 05. Larger than Neighbours
function largerThanNeighbours(args) {
	let lines = args.split('<br>'),
		count = +lines[0],
		arr = lines[1].split(' ').map(Number);
	
	function CountAppearances(arr, len) {
		let result = 0;
		
		for (let i = 1; i < count; i += 1) {
			if ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1])) {
				result += 1;
			}
		}
		
		return (result);
	}
	
	let result = CountAppearances(arr, count);
	console.log('Problem 05:\n' + result);
	return (result);
}

function runTestLargerThanNeighbours(input, output, actual) {
	document.getElementById(actual).innerHTML = largerThanNeighbours(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}