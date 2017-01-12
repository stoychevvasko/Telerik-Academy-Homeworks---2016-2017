function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestAllocateArray('P01_I01', 'P01_O01', 'P01_A01');
	console.log('===============================================');
	runTestLexicographicallyCompare('P02_I01', 'P02_O01', 'P02_A01');
	runTestLexicographicallyCompare('P02_I02', 'P02_O02', 'P02_A02');
	console.log('===============================================');
	runTestMaximalSequence('P03_I01', 'P03_O01', 'P03_A01');
	console.log('===============================================');
	runTestMaximalIncreasingSequence('P04_I01', 'P04_O01', 'P04_A01');
	console.log('===============================================');
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

// Problem 02. Lexicographically Compare

// function lexicographicallyCompare(args) {
// 	var arr = convertToJSON(args)[0],
// 		result = "",
// 		resultForConsole = "";
// 	if (arr[0] > arr[1]) {
// 		result = "&gt;";
// 		resultForConsole = ">";
// 	} else if (arr[0] < arr[1]) {
// 		result = "&lt;";
// 		resultForConsole = "<";
// 	} else {
// 		result = "=";
// 		resultForConsole = "=";
// 	}
// 	
// 	console.log('Problem 02:\n' + resultForConsole);
// 	return result;
// }

function lexicographicallyCompare(args) {
	var arr = convertToJSON(args)[0],
 		result = "";
		
	shorterArrayLength = (arr[0].length < arr[1].length) ? arr[0].length : arr[1].length;
		
	for (var i = 0; i < shorterArrayLength; i += 1) {
        if (arr[0][i] === arr[1][i]) {
            if (i === shorterArrayLength - 1) {
                if (arr[0].length < arr[1].length) {
                    result = "<"; 
                    break;
                } else if (arr[0].length = arr[1].length) {
                    result = "="; 
                    break;
                } else if (arr[0].length > arr[1].length) {
                    result = ">";
                    break;
                }
            }
            continue;
        } else if (arr[0][i] > arr[1][i]) {
            result = ">";
            break;
        } else if (arr[0][i] < arr[1][i]) {
            result = "<";
            break;
        }
    }
	
	console.log('Problem 02:\n' + result);
	
	return result;
}

function runTestLexicographicallyCompare(input, output, actual) {
	document.getElementById(actual).innerHTML = lexicographicallyCompare(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 03. Maximal Sequence
function maximalSequence(args) {
	var arr = convertToJSON(args)[0].map(Number),
		result = "",		
		len = arr.length,	
	    repeatsArray = [], 
        sequenceFound = [];

    // recursive method that returns the number of consecutive
    // equal elements from an array starting from a position "index"
    function lengthOfSequence(arr, index, arrayLength) {
        if (index + 1 >= arrayLength) {
            return 1;
            //   array exhausted, last element - sequence of 1 element
        }
        else if (arr[index] != arr[index + 1]) {
            return 1;
            //     next element is not equal - sequence of 1 element
        }
        else {
            return (1 + lengthOfSequence(arr, index + 1, arrayLength));
            //     next element is equal to current element - 1 is added to the next recursive instance            
        }
    }

    for (var i = 0; i < len; i++) {
        repeatsArray[i] = lengthOfSequence(arr, i, len);
    }

    var maxSequenceIndex = 0;

    for (var i = 0; i < len; i++) {
        if (repeatsArray[i] >= repeatsArray[maxSequenceIndex]) {
            maxSequenceIndex = i;
        }
    }

    for (var i = maxSequenceIndex; i < maxSequenceIndex + repeatsArray[maxSequenceIndex]; i++) {
        sequenceFound.push(arr[i]);
    }

	result = sequenceFound.length;
	console.log('Problem 03:\n' + result);
	return result;
}

function runTestMaximalSequence(input, output, actual) {
	document.getElementById(actual).innerHTML = maximalSequence(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 04. Maximal Increasing Sequence
function maximalIncreasingSequence(args) {
	var arr = convertToJSON(args)[0].map(Number),
		result = "",		
		len = arr.length,	
	    repeatsArray = [], 
        sequenceFound = [];
		
		// recursive method that returns the number of consecutive
    // equal elements from an array starting from a position "index"
    function lengthOfSequence(arr, index, arrayLength) {
        if (index + 1 >= arrayLength) {
            return 1;
            //   array exhausted, last element - sequence of 1 element
        }
        else if (arr[index] >= arr[index + 1]) {
            return 1;
            //     next element is greater - sequence of 1 element
        }
        else {
            return (1 + lengthOfSequence(arr, index + 1, arrayLength));
            //     next element is equal to current element - 1 is added to the next recursive instance            
        }
    }

    for (var i = 0; i < len; i++) {
        repeatsArray[i] = lengthOfSequence(arr, i, len);
    }

    var maxSequenceIndex = 0;

    for (var i = 0; i < len; i++) {
        if (repeatsArray[i] >= repeatsArray[maxSequenceIndex]) {
            maxSequenceIndex = i;
        }
    }

    for (var i = maxSequenceIndex; i < maxSequenceIndex + repeatsArray[maxSequenceIndex]; i++) {
        sequenceFound.push(arr[i]);
    }

	result = sequenceFound.length;
	console.log('Problem 04:\n' + result);
	return result;
}

function runTestMaximalIncreasingSequence(input, output, actual) {
	document.getElementById(actual).innerHTML = maximalIncreasingSequence(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}