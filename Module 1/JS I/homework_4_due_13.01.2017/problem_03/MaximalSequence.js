// Problem 03. Maximal Sequence - BGCoder format
function solve(args) {
	var arr = args,
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
	return result;
}