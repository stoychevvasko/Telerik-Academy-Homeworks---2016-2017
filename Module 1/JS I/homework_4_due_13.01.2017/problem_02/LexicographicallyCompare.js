// Problem 02. Lexicographically Compare - BGCoder format
function solve(args) {
	var arr = args,
		result = "",
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
	
	return result;
}

