function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestsolveExchangeIfGreater('P01_I01', 'P01_O01', 'P01_A01');
	runTestsolveExchangeIfGreater('P01_I02', 'P01_O02', 'P01_A02');
	runTestsolveExchangeIfGreater('P01_I03', 'P01_O03', 'P01_A03');
	console.log('===============================================');
	runTestsolveMultiplicationSign('P02_I01', 'P02_O01', 'P02_A01');
	runTestsolveMultiplicationSign('P02_I02', 'P02_O02', 'P02_A02');
	runTestsolveMultiplicationSign('P02_I03', 'P02_O03', 'P02_A03');
	runTestsolveMultiplicationSign('P02_I04', 'P02_O04', 'P02_A04');
	runTestsolveMultiplicationSign('P02_I05', 'P02_O05', 'P02_A05');
	console.log('===============================================');
	runTestsolveTheBiggestOfThree('P03_I01', 'P03_O01', 'P03_A01');
	runTestsolveTheBiggestOfThree('P03_I02', 'P03_O02', 'P03_A02');
	runTestsolveTheBiggestOfThree('P03_I03', 'P03_O03', 'P03_A03');
	runTestsolveTheBiggestOfThree('P03_I04', 'P03_O04', 'P03_A04');
	runTestsolveTheBiggestOfThree('P03_I05', 'P03_O05', 'P03_A05');
	console.log('===============================================');
	runTestsolveSortThreeNumbers('P04_I01', 'P04_O01', 'P04_A01');
	runTestsolveSortThreeNumbers('P04_I02', 'P04_O02', 'P04_A02');
	runTestsolveSortThreeNumbers('P04_I03', 'P04_O03', 'P04_A03');
	runTestsolveSortThreeNumbers('P04_I04', 'P04_O04', 'P04_A04');
	runTestsolveSortThreeNumbers('P04_I05', 'P04_O05', 'P04_A05');
	runTestsolveSortThreeNumbers('P04_I06', 'P04_O06', 'P04_A06');
	runTestsolveSortThreeNumbers('P04_I07', 'P04_O07', 'P04_A07');
	console.log('===============================================');
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
		console.log('Problem 01:   ' + (b + ' ' + a));
		return (b + ' ' + a); 
	}
	console.log('Problem 01:   ' + (a + ' ' + b));
	return (a + ' ' + b);
}

function runTestsolveExchangeIfGreater(input, output, actual) {
	document.getElementById(actual).innerHTML = solveExchangeIfGreater(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 02: Multiplication Sign
function solveMultiplicationSign(args) {
	var firstValue = convertToJSON(args)[0][0], 
		secondValue = convertToJSON(args)[0][1], 
		thirdValue = convertToJSON(args)[0][2];
	
    if (firstValue == 0 || secondValue == 0 || thirdValue == 0) {
		console.log('Problem 02:   ' + '0');
        return ('0');
    }

    if (firstValue > 0) {
        if (secondValue > 0) {
            if (thirdValue > 0) {
				console.log('Problem 02:   ' + '+');
                return ('+');
            } else {
				console.log('Problem 02:   ' + '-');
                return ('-');
            }
        } else {
            if (thirdValue > 0) {
				console.log('Problem 02:   ' + '-');
                return ('-');
            } else {
				console.log('Problem 02:   ' + '+');
                return ('+');
            }
        }
    } else {
        if (secondValue > 0) {
            if (thirdValue > 0) {
				console.log('Problem 02:   ' + '-');
                return ('-');
            } else {
				console.log('Problem 02:   ' + '+');
                return ('+');
            }
        } else {
            if (thirdValue > 0) {
				console.log('Problem 02:   ' + '+');
                return ('+');
            } else {
				console.log('Problem 02:   ' + '-');
                return ('-');
            }
        }
    }
}

function runTestsolveMultiplicationSign(input, output, actual) {
	document.getElementById(actual).innerHTML = solveMultiplicationSign(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 3: The Biggest of Three
function solveTheBiggestOfThree(args) {	
    var first = parseFloat(convertToJSON(args)[0][0]),
        second = parseFloat(convertToJSON(args)[0][1]),
        third = parseFloat(convertToJSON(args)[0][2]);

    if (first >= second) {
        if (first >= third) {
			console.log('Problem 03:   ' + first);
            return first;
        } else {
			console.log('Problem 03:   ' + third);
            return third;
        }
    } else if (second >= third) {
		console.log('Problem 03:   ' + second);
        return second;
    } else {
		console.log('Problem 03:   ' + third);
        return third;
    }
}

function runTestsolveTheBiggestOfThree(input, output, actual) {
	document.getElementById(actual).innerHTML = solveTheBiggestOfThree(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 4: Sort Three Numbers
function solveSortThreeNumbers(args) {	
	var a = +convertToJSON(args)[0][0],
		b = +convertToJSON(args)[0][1],
		c = +convertToJSON(args)[0][2];
	
	if (a > b && a > c) {
		if (b > c) {
			console.log('Problem 04:   ' + a + ' ' + b + ' ' + c);
			return (a + ' ' + b + ' ' + c);
		}
		else {
			console.log('Problem 04:   ' + a + ' ' + c + ' ' + b);
			return (a + ' ' + c + ' ' + b);
		}	
	}
	else if (b > a && b > c) {
		if (a > c) {
			console.log('Problem 04:   ' + b + ' ' + a + ' ' + c);
			return (b + ' ' + a + ' ' + c);
		}
		else {
			console.log('Problem 04:   ' + b + ' ' + c + ' ' + a);
			return (b + ' ' + c + ' ' + a);
		}
	}
	else {
		if (a > b) {
			console.log('Problem 04:   ' + c + ' ' + a + ' ' + b);
			return (c + ' ' + a + ' ' + b);
		}
		else {
			console.log('Problem 04:   ' + c + ' ' + b + ' ' + a);
			return (c + ' ' + b + ' ' + a);
		}
	}
}

function runTestsolveSortThreeNumbers(input, output, actual) {
	document.getElementById(actual).innerHTML = solveSortThreeNumbers(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

