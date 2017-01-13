function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestSayHello('P01_I01', 'P01_O01', 'P01_A01');
}

function convertToJSON(args) {	
	var input = args;
    var rawJSON = '[' + input.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(rawJSON);
	return arr;
}

// Problem 01: Say Hello
function sayHello(args) {	
	let name = args;
	
	function sayHello(name) {
		return (`Hello, ${name}!`);
	}
	
	let result = sayHello(name);
		
	console.log('Problem 01:\n' + result);
	return (result);
}

function runTestSayHello(input, output, actual) {
	document.getElementById(actual).innerHTML = sayHello(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}
