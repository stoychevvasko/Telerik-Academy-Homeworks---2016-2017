function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestReverseString('P01_I01', 'P01_O01', 'P01_A01');
	runTestReverseString('P01_I02', 'P01_O02', 'P01_A02');
	console.log('===============================================');
	runTestCorrectBrackets('P02_I01', 'P02_O01', 'P02_A01');
	runTestCorrectBrackets('P02_I02', 'P02_O02', 'P02_A02');
	console.log('===============================================');
	runTestSubsctringInText('P03_I01', 'P03_O01', 'P03_A01');
	console.log('===============================================');
}

function convertToJSON(args) {	
	var input = args;
    var rawJSON = '[' + input.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(rawJSON);
	return arr;
}

// Problem 01: Reverse string
function reverseString(args) {
	let arr = convertToJSON(args)[0][0],
		len = arr.length,
		result = '';
		
	for (let i = 0; i < len; i += 1) {
		result = ((arr[i]) + result);
	}
	
	console.log('Problem 01:\n' + result);
	return result;
}

function runTestReverseString(input, output, actual) {
	document.getElementById(actual).innerHTML = reverseString(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 02: Correct brackets
function correctBrackets(args) {
	let fullString = convertToJSON(args)[0][0],
		len = fullString.length,
		result = '';
	
	function evaluateBrackets(str) {
		if ((str.split('(').length) === (str.split(')').length)) {
			return true;
		}		
		
		return false;
	}
	
	result = (evaluateBrackets(fullString)?'Correct':'Incorrect');
	
	console.log('Problem 02:\n' + result);
	return result;
}

function runTestCorrectBrackets(input, output, actual) {
	document.getElementById(actual).innerHTML = correctBrackets(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 03: Sub-string in text
function subsctringInText(args) {
	let item = convertToJSON(args)[0][0].toLowerCase(),
		text = convertToJSON(args)[0][1].toLowerCase(),
		result = text.split(item).length - 1;
	
	if (result < 0) {
		result = 0;
	}
	
	console.log('Problem 03:\n' + result);
	return result;
}

function runTestSubsctringInText(input, output, actual) {
	document.getElementById(actual).innerHTML = subsctringInText(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}
