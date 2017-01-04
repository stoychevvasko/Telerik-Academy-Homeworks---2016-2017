function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestnumbersFrom1ToN('P01_I01', 'P01_O01', 'P01_A01');
	runTestnumbersFrom1ToN('P01_I02', 'P01_O02', 'P01_A02');
	console.log('===============================================');
}

function convertToJSON(args) {	
	var input = args;
    var rawJSON = '[' + input.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(rawJSON);
	return arr;
}

// Problem 01: Numbers from 1 to N
function numbersFrom1ToN(args) {
	var n = +convertToJSON(args)[0][0],
		result = "";	
	for (let i = 1; i <= n; i += 1) {
		result += (i + " ");
	}
	result = result.trim();
	console.log('Problem 01:   ' + result);
	return (result);
}

function runTestnumbersFrom1ToN(input, output, actual) {
	document.getElementById(actual).innerHTML = numbersFrom1ToN(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}