function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestsolveOddOrEven('P01_I01', 'P01_O01', 'P01_A01');
	runTestsolveOddOrEven('P01_I02', 'P01_O02', 'P01_A02');
	runTestsolveOddOrEven('P01_I03', 'P01_O03', 'P01_A03');
	runTestsolveOddOrEven('P01_I04', 'P01_O04', 'P01_A04');
	runTestsolveOddOrEven('P01_I05', 'P01_O05', 'P01_A05');
	console.log('===============================================');
	runTestsolveDivideBy7And5('P02_I01', 'P02_O01', 'P02_A01');
	runTestsolveDivideBy7And5('P02_I02', 'P02_O02', 'P02_A02');
	runTestsolveDivideBy7And5('P02_I03', 'P02_O03', 'P02_A03');
	runTestsolveDivideBy7And5('P02_I04', 'P02_O04', 'P02_A04');
	runTestsolveDivideBy7And5('P02_I05', 'P02_O05', 'P02_A05');
	runTestsolveDivideBy7And5('P02_I06', 'P02_O06', 'P02_A06');
	console.log('===============================================');
	runTestsolveRectangles('P03_I01', 'P03_O01', 'P03_A01');
	runTestsolveRectangles('P03_I02', 'P03_O02', 'P03_A02');
	runTestsolveRectangles('P03_I03', 'P03_O03', 'P03_A03');
	console.log('===============================================');
	runTestsolveThirdDigit('P04_I01', 'P04_O01', 'P04_A01');
	runTestsolveThirdDigit('P04_I02', 'P04_O02', 'P04_A02');
	runTestsolveThirdDigit('P04_I03', 'P04_O03', 'P04_A03');
	runTestsolveThirdDigit('P04_I04', 'P04_O04', 'P04_A04');
	runTestsolveThirdDigit('P04_I05', 'P04_O05', 'P04_A05');
	runTestsolveThirdDigit('P04_I06', 'P04_O06', 'P04_A06');
	console.log('===============================================');
	runTestsolveThirdBit('P05_I01', 'P05_O01', 'P05_A01');
	runTestsolveThirdBit('P05_I02', 'P05_O02', 'P05_A02');
	console.log('===============================================');
	runTestsolvePointInACircle('P06_I01', 'P06_O01', 'P06_A01');
	runTestsolvePointInACircle('P06_I02', 'P06_O02', 'P06_A02');
	runTestsolvePointInACircle('P06_I03', 'P06_O03', 'P06_A03');
	runTestsolvePointInACircle('P06_I04', 'P06_O04', 'P06_A04');
	runTestsolvePointInACircle('P06_I05', 'P06_O05', 'P06_A05');
	runTestsolvePointInACircle('P06_I06', 'P06_O06', 'P06_A06');
	runTestsolvePointInACircle('P06_I07', 'P06_O07', 'P06_A07');
	runTestsolvePointInACircle('P06_I08', 'P06_O08', 'P06_A08');
	runTestsolvePointInACircle('P06_I09', 'P06_O09', 'P06_A09');
	runTestsolvePointInACircle('P06_I10', 'P06_O10', 'P06_A10');
	console.log('===============================================');
	runTestsolvePrimeCheck('P07_I01', 'P07_O01', 'P07_A01');
	runTestsolvePrimeCheck('P07_I02', 'P07_O02', 'P07_A02');
	runTestsolvePrimeCheck('P07_I03', 'P07_O03', 'P07_A03');
	runTestsolvePrimeCheck('P07_I04', 'P07_O04', 'P07_A04');
	runTestsolvePrimeCheck('P07_I05', 'P07_O05', 'P07_A05');
	console.log('===============================================');
	runTestsolveTrapezoids('P08_I01', 'P08_O01', 'P08_A01');
	runTestsolveTrapezoids('P08_I02', 'P08_O02', 'P08_A02');
	runTestsolveTrapezoids('P08_I03', 'P08_O03', 'P08_A03');
	runTestsolveTrapezoids('P08_I04', 'P08_O04', 'P08_A04');
	runTestsolveTrapezoids('P08_I05', 'P08_O05', 'P08_A05');
	console.log('===============================================');
	runTestsolvePointCircleRectangle('P09_I01', 'P09_O01', 'P09_A01');
	runTestsolvePointCircleRectangle('P09_I02', 'P09_O02', 'P09_A02');
	runTestsolvePointCircleRectangle('P09_I03', 'P09_O03', 'P09_A03');
	runTestsolvePointCircleRectangle('P09_I04', 'P09_O04', 'P09_A04');
	console.log('===============================================');
}

function convertToJSON(args) {	
	var input = args;
    var rawJSON = '[' + input.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(rawJSON);
	return arr;
}



// Problem 01: Odd or Even
function solveOddOrEven(args) {	
	var n = convertToJSON(args);
    var result = ((n % 2) === 0) ? ('even ' + n) : ('odd ' + n);
	console.log('Problem 01:   ' + result);
	return result;
}

function runTestsolveOddOrEven(input, output, actual) {
	document.getElementById(actual).innerHTML = solveOddOrEven(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 02: Divide by 7 and 5
function solveDivideBy7And5(args) {
    var n = convertToJSON(args);
    var isDivisible = (n % 7 === 0 && n % 5 === 0);
    var result = (isDivisible + ' ' + n);
	console.log('Problem 02:   ' + result);
	return result;
}

function runTestsolveDivideBy7And5(input, output, actual) {
	document.getElementById(actual).innerHTML = solveDivideBy7And5(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 03: Rectangles
function solveRectangles(args) {	
	var a = convertToJSON(args)[0][0];	
    var b = convertToJSON(args)[0][1];	
    var perimeter = 2.0 * (+(a) + +(b));
    var surface = a * b;
    var result = surface.toFixed(2) + ' ' + perimeter.toFixed(2);
	console.log('Problem 03:   ' + result);
    return result;
}

function runTestsolveRectangles(input, output, actual) {
	document.getElementById(actual).innerHTML = solveRectangles(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 04. Third Digit
function solveThirdDigit(args) {	
	var n = convertToJSON(args)[0][0];
    var thirdDigit = (n.slice(-3, -2) === '') ? '0' : n.slice(-3, -2);
    var result = (thirdDigit === '7') ? 'true' : ('false ' + thirdDigit);
	console.log('Problem 04:   ' + result);
	return result;
}

function runTestsolveThirdDigit(input, output, actual) {
	document.getElementById(actual).innerHTML = solveThirdDigit(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 05. Third Bit
function solveThirdBit(args) {
	var n = (convertToJSON(args)[0][0] >>> 0);	
    var nBase2 = '000' + n.toString(2);	
    var result = nBase2.slice(-4, -3);
	console.log('Problem 05:   ' + result);
	return result;
}

function runTestsolveThirdBit(input, output, actual) {
	document.getElementById(actual).innerHTML = solveThirdBit(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 06. Point In A Circle
function solvePointInACircle(args) {
	var x = convertToJSON(args)[0][0],
		y = convertToJSON(args)[0][1],
		distance = Math.sqrt(x * x + y * y),
		isInCircle = (distance <= 2),
		result = (isInCircle ? "yes " : "no ") + distance.toFixed(2);
	console.log('Problem 06:   ' + result);
	return result;
}

function runTestsolvePointInACircle(input, output, actual) {
	document.getElementById(actual).innerHTML = solvePointInACircle(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 07: Prime Check
function solvePrimeCheck(args) {
    var n = convertToJSON(args)[0][0];	
    var isPrime = (n > 1);
    var i = 2;
    while (i <= Math.sqrt(n)) {
        if (n % i++ < 1) isPrime = false;
    }
	console.log('Problem 07:   ' + isPrime);
    return isPrime;
}

function runTestsolvePrimeCheck(input, output, actual) {
	document.getElementById(actual).innerHTML = solvePrimeCheck(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 08: Trapezoids
function solveTrapezoids(args) {
	var a = +convertToJSON(args)[0][0],
		b = +convertToJSON(args)[0][1],
		h = +convertToJSON(args)[0][2],
		result = (0.5 * (a + b) * h).toFixed(7);
	console.log('Problem 08:   ' + result);
	return result;
}

function runTestsolveTrapezoids(input, output, actual) {
	document.getElementById(actual).innerHTML = solveTrapezoids(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 09: Point, Circle, Rectangle
function solvePointCircleRectangle(args) {
	var x = +convertToJSON(args)[0][0],
		y = +convertToJSON(args)[0][1],    
		circle = [1.0, 1.0, 1.5],
		rectangle = [[-1.0, 5.0], [1.0, -1.0]],
		pointToCircleCenter = Math.sqrt(Math.pow((x + (0 - circle[0])), 2) + Math.pow((y + (0 - circle[1])), 2)),
		inCircle = (pointToCircleCenter <= circle[2]) ? "inside circle " : "outside circle ",
		inRectangle = (( x >= rectangle[0][0] && x <= rectangle[0][1] ) && ( y <= rectangle[1][0] && y >= rectangle[1][1] )) ? "inside rectangle" : "outside rectangle";
	console.log('Problem 09:   ' + (inCircle + inRectangle));
	return (inCircle + inRectangle);
}

function runTestsolvePointCircleRectangle(input, output, actual) {
	document.getElementById(actual).innerHTML = solvePointCircleRectangle(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}