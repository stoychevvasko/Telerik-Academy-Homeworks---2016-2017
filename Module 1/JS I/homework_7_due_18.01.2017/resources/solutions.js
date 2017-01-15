function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestReverseString('P01_I01', 'P01_O01', 'P01_A01');
	runTestReverseString('P01_I02', 'P01_O02', 'P01_A02');
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

