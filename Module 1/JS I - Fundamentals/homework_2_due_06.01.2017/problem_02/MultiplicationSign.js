// Problem 2: Multiplication Sign - BGCoder format
function solve(args) {
	var firstValue = +args[0], 
		secondValue = +args[1], 
		thirdValue = +args[2];
	
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