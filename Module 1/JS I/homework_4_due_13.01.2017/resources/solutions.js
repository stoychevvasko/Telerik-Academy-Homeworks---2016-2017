function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestAllocateArray('P01_I01', 'P01_O01', 'P01_A01');
	console.log('===============================================');
	runTestLexicographicallyCompare('P02_I01', 'P02_O01', 'P02_A01');
	runTestLexicographicallyCompare('P02_I02', 'P02_O02', 'P02_A02');
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