function runScript() {	
	runTestsolveOddOrEven('P01_I01', 'P01_O01', 'P01_A01');
	runTestsolveOddOrEven('P01_I02', 'P01_O02', 'P01_A02');
	runTestsolveOddOrEven('P01_I03', 'P01_O03', 'P01_A03');
	runTestsolveOddOrEven('P01_I04', 'P01_O04', 'P01_A04');
	runTestsolveOddOrEven('P01_I05', 'P01_O05', 'P01_A05');
}

function convertToJSON(args) {	
	var inputs = args;
    var jsonstr = '[' + inputs.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(jsonstr);
	return arr;
}

function runTestsolveOddOrEven(input, output, actual) {
	document.getElementById(actual).innerHTML = solveOddOrEven(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	}
}

// Problem 01: Odd or Even
function solveOddOrEven(args) {	
	var n = convertToJSON(args);		
    var result = ((n % 2) === 0) ? ('even ' + n) : ('odd ' + n);	
	return result;
}

