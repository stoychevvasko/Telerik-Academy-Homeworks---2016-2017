function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestnumbersFrom1ToN('P01_I01', 'P01_O01', 'P01_A01');
	runTestnumbersFrom1ToN('P01_I02', 'P01_O02', 'P01_A02');
	console.log('===============================================');
	runTestmMSA('P02_I01', 'P02_O01', 'P02_A01');
	runTestmMSA('P02_I02', 'P02_O02', 'P02_A02');
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

// Problem 02: MMSA (Min, Max, Sum, Average) of N Numbers
function mMSA(args) {
	var arr = convertToJSON(args)[0].map(Number);
	let min = arr[0],
		max = arr[0],
		sum = 0,
		avg = 0;
	
	for (var i = 0; i < arr.length; i += 1) {
		if (min > arr[i]) {
			min = arr[i];
		}
		
		if (max < arr[i]) {
			max = arr[i]
		}
		
		sum += arr[i];
	}
	
	avg = sum / arr.length;
	
	var result = "<p>min=" + min.toFixed(2) + "</p>" + 
				 "<p>max=" + max.toFixed(2) + "</p>" + 
				 "<p>sum=" + sum.toFixed(2) + "</p>" + 
				 "<p>avg=" + avg.toFixed(2) + "</p>",
				 
		resultForConsole = "min=" + min.toFixed(2) + "   " + 
						   "max=" + max.toFixed(2) + "   " + 
						   "sum=" + sum.toFixed(2) + "   " + 
						   "avg=" + avg.toFixed(2) + "   ";
	
	console.log('Problem 02:   ' + resultForConsole);
	return result;
}

function runTestmMSA(input, output, actual) {
	document.getElementById(actual).innerHTML = mMSA(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}