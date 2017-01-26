function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestFormatWithPlaceholders('P01_I01', 'P01_O01', 'P01_A01');
	runTestFormatWithPlaceholders('P01_I02', 'P01_O02', 'P01_A02');	
	console.log('===============================================');
}

function convertToJSON(args) {	
	var input = args;
    var rawJSON = '[' + input.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(rawJSON);
	return arr;
}

// Problem 01. Format with placeholders
function formatWithPlaceholders(args) {
	let result = '';
		
	console.log('Problem 01:\n' + result);
	return result;
}

function runTestFormatWithPlaceholders(input, output, actual) {
	document.getElementById(actual).innerHTML = formatWithPlaceholders(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}