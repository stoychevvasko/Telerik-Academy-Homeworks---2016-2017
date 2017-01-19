function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestFormatWithPlaceholders('P01_I01', 'P01_O01', 'P01_A01');
	runTestFormatWithPlaceholders('P01_I02', 'P01_O02', 'P01_A02');	
	console.log('===============================================');
}

function convertToJSON(args) {	
	var input = args;
    var rawJSON = '[' + input.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(rawJSON);
	return arr;
}

// Problem 01. Format with placeholders
function formatWithPlaceholders(args) {
	let data = JSON.parse(args[0]),
		result = '';
		
    String.prototype.replacePlaceholders = function (data) {
        let result = this;
        for (const option in data) {
            if ({}.hasOwnProperty.call(data, option)) {
                let regex = new RegExp(`#{${option}}`, 'g');
                result = result.replace(regex, data[option]);
            }
        }

        return result;
    };

    result = args[1].replacePlaceholders(data);

	console.log('Problem 01:\n' + result);
	return result;
}

function runTestFormatWithPlaceholders(input, output, actual) {
	document.getElementById(actual).innerHTML = formatWithPlaceholders(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}