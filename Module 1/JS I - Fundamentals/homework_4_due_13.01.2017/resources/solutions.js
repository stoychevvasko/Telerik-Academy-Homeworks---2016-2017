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
	runTestSelectionSort('P05_I01', 'P05_O01', 'P05_A01');
	runTestSelectionSort('P05_I02', 'P05_O02', 'P05_A02');
	console.log('===============================================');
	runTestFrequentNumber('P06_I01', 'P06_O01', 'P06_A01');
	console.log('===============================================');
	runTestBinarySearch('P07_I01', 'P07_O01', 'P07_A01');
	console.log('===============================================');
	runTestPrimeNumbers('P08_I01', 'P08_O01', 'P08_A01');
	runTestPrimeNumbers('P08_I02', 'P08_O02', 'P08_A02');
	runTestPrimeNumbers('P08_I03', 'P08_O03', 'P08_A03');
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

// Problem 05. Selection Sort
function selectionSort(args) {
	var arr = convertToJSON(args)[0],
	result = "",
	resultForConsole = "",
	resultHTML = "";	
	
	var min,
        minIndex,
        swapNumber;

    for (var i = 0; i < arr.length; i++) {
        min = arr[i];
        minIndex = i;

        for (var j = i; j < arr.length; j++) {
            if (parseFloat(min) > parseFloat(arr[j])) {
                min = arr[j];
                minIndex = j;
            }
        }
		
        swapNumber = arr[minIndex];
        arr[minIndex] = arr[i];
        arr[i] = swapNumber;
    }	
	
	result = arr;
	resultForConsole = arr.join("\n");
	resultHTML = "<p>" + (arr.join("</p><p>")) + "</p>"
	
	console.log('Problem 05:\n' + resultForConsole);
	return resultHTML;
}

function runTestSelectionSort(input, output, actual) {
	document.getElementById(actual).innerHTML = selectionSort(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 06. Frequent Number
function frequentNumber(args) {
	var result = "";	
	let arr = convertToJSON(args)[0].map(Number);
    arr.shift();

    let frequency = {};
    let maxFrequency = 0;
    let maxElement; 

    for (let num in arr) {        
        frequency[arr[num]] = (frequency[arr[num]] || 0) + 1;
        if (frequency[arr[num]] > maxFrequency) {
            maxFrequency = frequency[arr[num]];
            maxElement = arr[num];
        }
    }
    
	result = (maxElement + ' (' + maxFrequency + ' times)');	
	console.log('Problem 06:\n' + result);
	return result;
}

function runTestFrequentNumber(input, output, actual) {
	document.getElementById(actual).innerHTML = frequentNumber(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 07. Binary Search
function binarySearch(args) {
	var result = "";	
	let arr = convertToJSON(args)[0].map(Number);
    arr.shift();
    
    let soughtNum = arr.pop();

    arr.sort(function(a, b) {return a-b;});

    var isExisting = false;

    for (let i = 0; i < arr.length; i += 1) {
        if (arr[i] == soughtNum) {
            isExisting = true;
        }
    }

    if (!isExisting) {
        result = ("-1");
    } else {
        let imin = 0;
        let imax = arr.length;

        while (imax >= imin) {
            let imid = imin + Math.floor((imax - imin) / 2);

            if (arr[imid] === soughtNum) {
                result = (imid);
                break;
            }
            else if (arr[imid] < soughtNum) {
                imin = imid + 1;
            }
            else {
                imax = imid - 1;
            }
        }
    }	
	
	console.log('Problem 07:\n' + result);
	return result;
}

function runTestBinarySearch(input, output, actual) {
	document.getElementById(actual).innerHTML = binarySearch(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 08. Prime Numbers
function primeNumbers(args) {	
	var n = +convertToJSON(args)[0],
		result = (n);	

    for (let i = n; i >= 0; i -= 1) {
        let isPrime = true;

        for (j = 2; j <= Math.sqrt(i); j += 1) {
            if (i % j === 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime === true) {
            result = (i);			
            break;
        }
    }    
	
	console.log('Problem 08:\n' + result);
	return result;
}

function runTestPrimeNumbers(input, output, actual) {
	document.getElementById(actual).innerHTML = primeNumbers(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}