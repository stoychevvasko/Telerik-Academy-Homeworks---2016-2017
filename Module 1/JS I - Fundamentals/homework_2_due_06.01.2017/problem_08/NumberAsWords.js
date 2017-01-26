// Problem 08: Number as Words - BGCoder format
function solve(args) {
	var num = +args[0];
	var result = ''; 

    // for numbers with hundreds
    if ((num - (num % 100)) != 0) {
        switch (num - (num % 100)) {
            case 100: result = 'one hundred'; break;
            case 200: result = 'two hundred'; break;
            case 300: result = 'three hundred'; break;
            case 400: result = 'four hundred'; break;
            case 500: result = 'five hundred'; break;
            case 600: result = 'six hundred'; break;
            case 700: result = 'seven hundred'; break;
            case 800: result = 'eight hundred'; break;
            case 900: result = 'nine hundred'; break;
        }

        // for 101-119, 201-219, 301-319, etc.
        if (num % 100 < 20) {
            switch (num % 100) {
                case 1: result += ' and one'; break;
                case 2: result += ' and two'; break;
                case 3: result += ' and three'; break;
                case 4: result += ' and four'; break;
                case 5: result += ' and five'; break;
                case 6: result += ' and six'; break;
                case 7: result += ' and seven'; break;
                case 8: result += ' and eight'; break;
                case 9: result += ' and nine'; break;
                case 10: result += ' and ten'; break;
                case 11: result += ' and eleven'; break;
                case 12: result += ' and twelve'; break;
                case 13: result += ' and thirteen'; break;
                case 14: result += ' and fourteen'; break;
                case 15: result += ' and fifteen'; break;
                case 16: result += ' and sixteen'; break;
                case 17: result += ' and seventeen'; break;
                case 18: result += ' and eighteen'; break;
                case 19: result += ' and nineteen'; break;
            }
        } else { 
			// for 120-199, 220-299, 320-399, etc.
            switch ((num % 100) - ((num % 100) % 10)) {
                case 20: result += ' and twenty'; break;
                case 30: result += ' and thirty'; break;
                case 40: result += ' and forty'; break;
                case 50: result += ' and fifty'; break;
                case 60: result += ' and sixty'; break;
                case 70: result += ' and seventy'; break;
                case 80: result += ' and eighty'; break;
                case 90: result += ' and ninety'; break;
            }

            switch (num % 10) {
                case 1: result += ' one'; break;
                case 2: result += ' two'; break;
                case 3: result += ' three'; break;
                case 4: result += ' four'; break;
                case 5: result += ' five'; break;
                case 6: result += ' six'; break;
                case 7: result += ' seven'; break;
                case 8: result += ' eight'; break;
                case 9: result += ' nine'; break;
            }
        }
    } else { 
		// for numbers without hundreds
        if (num < 20) {
			// for 0-19
            switch (num) {
                case 0: result += 'zero'; break;
                case 1: result += 'one'; break;
                case 2: result += 'two'; break;
                case 3: result += 'three'; break;
                case 4: result += 'four'; break;
                case 5: result += 'five'; break;
                case 6: result += 'six'; break;
                case 7: result += 'seven'; break;
                case 8: result += 'eight'; break;
                case 9: result += 'nine'; break;
                case 10: result += 'ten'; break;
                case 11: result += 'eleven'; break;
                case 12: result += 'twelve'; break;
                case 13: result += 'thirteen'; break;
                case 14: result += 'fourteen'; break;
                case 15: result += 'fifteen'; break;
                case 16: result += 'sixteen'; break;
                case 17: result += 'seventeen'; break;
                case 18: result += 'eighteen'; break;
                case 19: result += 'nineteen'; break;
            }
        } else { 
			// for 20-99
            switch ((num - (num % 10))/10) {
                case 2: result = 'twenty'; break;
                case 3: result = 'thirty'; break;
                case 4: result = 'forty'; break;
                case 5: result = 'fifty'; break;
                case 6: result = 'sixty'; break;
                case 7: result = 'seventy'; break;
                case 8: result = 'eighty'; break;
                case 9: result = 'ninety'; break;
            }

            switch (num % 10) {
                case 1: result += ' one'; break;
                case 2: result += ' two'; break;
                case 3: result += ' three'; break;
                case 4: result += ' four'; break;
                case 5: result += ' five'; break;
                case 6: result += ' six'; break;
                case 7: result += ' seven'; break;
                case 8: result += ' eight'; break;
                case 9: result += ' nine'; break;
            }
        }
    }
	result = (result.charAt(0).toUpperCase() + result.slice(1));	
    return result;
}