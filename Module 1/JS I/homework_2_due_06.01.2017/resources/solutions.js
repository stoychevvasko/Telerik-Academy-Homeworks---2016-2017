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
	runTestsolveDigitAsWord('P05_I01', 'P05_O01', 'P05_A01');
	runTestsolveDigitAsWord('P05_I02', 'P05_O02', 'P05_A02');
	runTestsolveDigitAsWord('P05_I03', 'P05_O03', 'P05_A03');
	runTestsolveDigitAsWord('P05_I04', 'P05_O04', 'P05_A04');
	runTestsolveDigitAsWord('P05_I05', 'P05_O05', 'P05_A05');
	runTestsolveDigitAsWord('P05_I06', 'P05_O06', 'P05_A06');
	runTestsolveDigitAsWord('P05_I07', 'P05_O07', 'P05_A07');
	runTestsolveDigitAsWord('P05_I08', 'P05_O08', 'P05_A08');
	console.log('===============================================');
	runTestsolveQuadraticEquation('P06_I01', 'P06_O01', 'P06_A01');
	runTestsolveQuadraticEquation('P06_I02', 'P06_O02', 'P06_A02');
	runTestsolveQuadraticEquation('P06_I03', 'P06_O03', 'P06_A03');
	runTestsolveQuadraticEquation('P06_I04', 'P06_O04', 'P06_A04');
	runTestsolveQuadraticEquation('P06_I05', 'P06_O05', 'P06_A05');
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

// Problem 03: The Biggest of Three
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

// Problem 04: Sort Three Numbers
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

// Problem 05: Digit As Word
function solveDigitAsWord(args) {
	var currentValue = +convertToJSON(args)[0][0];	
	switch(currentValue) {
    case 0:
		var result = ('zero');
		console.log('Problem 05:   ' + result);
        return result;        
    case 1:
		var result = ('one');
		console.log('Problem 05:   ' + result);
        return result;        
	case 2:
		var result = ('two');
		console.log('Problem 05:   ' + result);
        return result;        
	case 3:
		var result = ('three');
		console.log('Problem 05:   ' + result);
        return result;        
	case 4:
		var result = ('four');
		console.log('Problem 05:   ' + result);
        return result;        
	case 5:
		var result = ('five');
		console.log('Problem 05:   ' + result);
        return result;        
	case 6:
		var result = ('six');
		console.log('Problem 05:   ' + result);
        return result;        
	case 7:
		var result = ('seven');
		console.log('Problem 05:   ' + result);
        return result;        
	case 8:
		var result = ('eight');
		console.log('Problem 05:   ' + result);
        return result;        
	case 9:
		var result = ('nine');
		console.log('Problem 05:   ' + result);
        return result;        
    default:
        var result = ('not a digit');
		console.log('Problem 05:   ' + result);
        return result;        
	}
}

function runTestsolveDigitAsWord(input, output, actual) {
	document.getElementById(actual).innerHTML = solveDigitAsWord(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 06: Quadratic Equation
function solveQuadraticEquation(args) {
	var a = +convertToJSON(args)[0][0],
		b = +convertToJSON(args)[0][1],
		c = +convertToJSON(args)[0][2],
		determinant = +(b * b - 4 * a * c);		
		
	if (determinant < 0) {
		var result = ('no real roots');
		console.log('Problem 06:   ' + result);
		return result;
	}
	
	if (determinant == 0) {
		var result = ('x1=x2=' + (-b / (2 * a)).toFixed(2));
		console.log('Problem 06:   ' + result);
		return result;
	}
	
	if (determinant > 0) {
		var x1 = (((Math.sqrt(determinant)) - b) / (2 * a)).toFixed(2),
			x2 = (((-Math.sqrt(determinant)) - b) / (2 * a)).toFixed(2);
				
		if (x1 > x2) {
			if ((x1 > 0) || (x2 > 0)) {
				var temp = x1,
					x1 = x2,
					x2 = temp;
			}
		}
		
		if ((x1 < 0) && (x2 < 0)) {
			var temp1 = x1,
				x1 = x2,
				x2 = temp1;
		}
		
		var result = ('x1=' + x1 + '; x2=' + x2);
		console.log('Problem 06:   ' + result);
		return result;
	}
}

function runTestsolveQuadraticEquation(input, output, actual) {
	document.getElementById(actual).innerHTML = solveQuadraticEquation(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}