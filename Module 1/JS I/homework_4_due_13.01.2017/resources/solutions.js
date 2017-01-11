function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestAllocateArray('P01_I01', 'P01_O01', 'P01_A01');	
}

function convertToJSON(args) {	
	var input = args;
    var rawJSON = '[' + input.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(rawJSON);
	return arr;
}

// Problem 01: Numbers from 1 to N
function allocateArray(args) {
	var n = +convertToJSON(args)[0][0],
		result = "",
		resultHtml = "";
	for (let i = 0; i < n; i += 1) {
		result += ((i * 5) + "\n");
		resultHtml += (("<p>" + (i * 5) + "</p>"))	;
	}
	result = result.trim();	
	console.log('Problem 01:\n' + result);
	return (resultHtml);
}

function runTestAllocateArray(input, output, actual) {
	document.getElementById(actual).innerHTML = allocateArray(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

