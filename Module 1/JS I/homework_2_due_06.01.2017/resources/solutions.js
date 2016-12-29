function runScript() {		
	runTestsolveExchangeIfGreater('P01_I01', 'P01_O01', 'P01_A01');
	runTestsolveExchangeIfGreater('P01_I02', 'P01_O02', 'P01_A02');
	runTestsolveExchangeIfGreater('P01_I03', 'P01_O03', 'P01_A03');
	
	runTestsolveMultiplicationSign('P02_I01', 'P02_O01', 'P02_A01');
	runTestsolveMultiplicationSign('P02_I02', 'P02_O02', 'P02_A02');
	runTestsolveMultiplicationSign('P02_I03', 'P02_O03', 'P02_A03');
	runTestsolveMultiplicationSign('P02_I04', 'P02_O04', 'P02_A04');
	runTestsolveMultiplicationSign('P02_I05', 'P02_O05', 'P02_A05');
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

// Problem 02: Multiplication Sign
function solveMultiplicationSign(args) {
	var firstValue = convertToJSON(args)[0][0], 
		secondValue = convertToJSON(args)[0][1], 
		thirdValue = convertToJSON(args)[0][2];
	
    if (firstValue == 0 || secondValue == 0 || thirdValue == 0) {
        return ('0');
    }

    if (firstValue > 0) {
        if (secondValue > 0) {
            if (thirdValue > 0) {
                return ('+');
            } else {
                return ('-');
            }
        } else {
            if (thirdValue > 0) {
                return ('-');
            } else {
                return ('+');
            }
        }
    } else {
        if (secondValue > 0) {
            if (thirdValue > 0) {
                return ('-');
            } else {
                return ('+');
            }
        } else {
            if (thirdValue > 0) {
                return ('+');
            } else {
                return ('-');
            }
        }
    }
}

function runTestsolveMultiplicationSign(input, output, actual) {
	document.getElementById(actual).innerHTML = solveMultiplicationSign(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	}
}
