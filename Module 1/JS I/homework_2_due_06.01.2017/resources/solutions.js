function runScript() {		
	runTestsolveExchangeIfGreater('P01_I01', 'P01_O01', 'P01_A01');
	runTestsolveExchangeIfGreater('P01_I02', 'P01_O02', 'P01_A02');
	runTestsolveExchangeIfGreater('P01_I03', 'P01_O03', 'P01_A03');
}

function convertToJSON(args) {	
	var input = args;
    var rawJSON = '[' + input.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(rawJSON);
	return arr;
}

// Problem 01: Exchange If Greater
function solveExchangeIfGreater(args) {
	var a = +convertToJSON(args)[0][0],
		b = +convertToJSON(args)[0][1];
if (a > b) {	
	return (b + ' ' + a);
}
return (a + ' ' + b);	
}

function runTestsolveExchangeIfGreater(input, output, actual) {
document.getElementById(actual).innerHTML = solveExchangeIfGreater(document.getElementById(input).innerHTML);
if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
	document.getElementById(actual).className += ' incorrect';
	}
}

