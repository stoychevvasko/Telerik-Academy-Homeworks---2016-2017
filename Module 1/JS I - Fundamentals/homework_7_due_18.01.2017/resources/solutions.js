function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestReverseString('P01_I01', 'P01_O01', 'P01_A01');
	runTestReverseString('P01_I02', 'P01_O02', 'P01_A02');
	console.log('===============================================');
	runTestCorrectBrackets('P02_I01', 'P02_O01', 'P02_A01');
	runTestCorrectBrackets('P02_I02', 'P02_O02', 'P02_A02');
	console.log('===============================================');
	runTestSubsctringInText('P03_I01', 'P03_O01', 'P03_A01');
	console.log('===============================================');
	runTestParseTags('P04_I01', 'P04_O01', 'P04_A01');
	console.log('===============================================');
	runTestNBSP('P05_I01', 'P05_O01', 'P05_A01');
	runTestNBSP('P05_I02', 'P05_O02', 'P05_A02');
	console.log('===============================================');
	runTestExtractTextFromHTML('P06_I01', 'P06_O01', 'P06_A01');
	console.log('===============================================');
	runTestParseUrl('P07_I01', 'P07_O01', 'P07_A01');
	console.log('===============================================');
	runTestReplaceTags('P08_I01', 'P08_O01', 'P08_A01');
	console.log('===============================================');
}

function convertToJSON(args) {	
	var input = args;
    var rawJSON = '[' + input.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(rawJSON);
	return arr;
}

// Problem 01: Reverse string
function reverseString(args) {
	let arr = convertToJSON(args)[0][0],
		len = arr.length,
		result = '';
		
	for (let i = 0; i < len; i += 1) {
		result = ((arr[i]) + result);
	}
	
	console.log('Problem 01:\n' + result);
	return result;
}

function runTestReverseString(input, output, actual) {
	document.getElementById(actual).innerHTML = reverseString(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 02: Correct brackets
function correctBrackets(args) {
	let fullString = convertToJSON(args)[0][0],
		len = fullString.length,
		result = '';
	
	function evaluateBrackets(str) {
		if ((str.split('(').length) === (str.split(')').length)) {
			return true;
		}		
		
		return false;
	}
	
	result = (evaluateBrackets(fullString)?'Correct':'Incorrect');
	
	console.log('Problem 02:\n' + result);
	return result;
}

function runTestCorrectBrackets(input, output, actual) {
	document.getElementById(actual).innerHTML = correctBrackets(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 03: Sub-string in text
function subsctringInText(args) {
	let item = convertToJSON(args)[0][0].toLowerCase(),
		text = convertToJSON(args)[0][1].toLowerCase(),
		result = text.split(item).length - 1;
	
	if (result < 0) {
		result = 0;
	}
	
	console.log('Problem 03:\n' + result);
	return result;
}

function runTestSubsctringInText(input, output, actual) {
	document.getElementById(actual).innerHTML = subsctringInText(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 04: Parse tags
function parseTags(args) {
	let text = args.substr(3, args.length - 6),
		len = text.length,
		toUpperEnabled = false,
		toLowerEnabled = false,
		insideTag = false,
		thisTag = '',
		result = [];
	
	for (let i = 0; i < len; i += 1) {
		if (text[i] === '<') {
			insideTag = true;
			i += 1;
		}
		
		if (insideTag) {						
			switch (text.substr(i).split('>')[0]) {
				case 'orgcase': {
					thisTag = 'orgcase';					
					toUpperEnabled = false;
					toLowerEnabled = false;					
					i += thisTag.length;
					insideTag = false;										
					continue;
				}
				case '/orgcase': {
					thisTag = '/orgcase';					
					i += thisTag.length;
					insideTag = false;										
					continue;
				}
				case 'upcase': {
					thisTag = 'upcase';					
					toUpperEnabled = true;
					i += thisTag.length;
					insideTag = false;										
					continue;
				}
				case '/upcase': {
					thisTag = '/upcase';					
					toUpperEnabled = false;
					i += thisTag.length;
					insideTag = false;										
					continue;
				}
				case 'lowcase': {
					thisTag = 'lowcase';					
					toLowerEnabled = true;
					i += thisTag.length;
					insideTag = false;										
					continue;
				}
				case '/lowcase': {
					thisTag = '/lowcase';					
					toLowerEnabled = false;
					i += thisTag.length;
					insideTag = false;										
					continue;
				}
			}
		} 
		
		if (!insideTag) {
			if (toUpperEnabled) {
				result.push(text[i].toUpperCase());				
				continue;
			}
			
			if (toLowerEnabled) {
				result.push(text[i].toLowerCase());				
				continue;
			}
			
			result.push(text[i]);			
		}
	}
	
	result = result.join('');
	
	console.log('Problem 04:\n' + result);
	return result;
}

function runTestParseTags(input, output, actual) {
	document.getElementById(actual).innerHTML = parseTags(document.getElementById(input).value);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 05. NBSP
function nbsp(args) {
	let fullString = convertToJSON(args)[0][0],
		result = fullString.split(' ').join('&nbsp');		
		
	console.log('Problem 05:\n' + result);
	return result;
}

function runTestNBSP(input, output, actual) {
	document.getElementById(actual).innerHTML = nbsp(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 06. Extract text from HTML
function extractTextFromHTML(args) {
	let input = convertToJSON(args)[0],
		matchTags = /<.*?>/ig,
		result = '';	

    for (let line of input) {
        result += line.replace(matchTags, '').trim();
    }
	
	console.log('Problem 06:\n' + result);
	return result;
}

function runTestExtractTextFromHTML(input, output, actual) {
	document.getElementById(actual).innerHTML = extractTextFromHTML(document.getElementById(input).value);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 07. Parse URL
function parseUrl(args) {
	let input = convertToJSON(args)[0][0],
		protocol = input.split(':')[0],		
		server = input.split('/')[2],
		resource = input.split(server)[1],
		result = '';
	
	result += ('<p>protocol: ' + protocol + '</p>');
	result += ('<p>server: ' + server + '</p>');
	result += ('<p>resource: ' + resource + '</p>');
	
	console.log('Problem 07:\n' + result);
	return result;
}

function runTestParseUrl(input, output, actual) {
	document.getElementById(actual).innerHTML = parseUrl(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 08. Replace tags
function replaceTags(args) {
	let input =  args.split('<a href='),
		result = '';
	
	for (let i = 0; i < input.length; i += 1) {
		
		let part = input[i];
		if (part[0] === '"') {
			let url = ('(' + part.split('</a>')[0].split('>')[0].split('"')[1] + ')'),
				linkText = ('[' + part.split('</a>')[0].split('>')[1] + ']'),
				ending = part.split('</a>')[1];
			
			part = (linkText + url + ending);
		}
		
		result += (part);
	}
		
	result = result.split("[ '")[1].split("' ]")[0];
		
	console.log('Problem 08:\n' + result);
	return result;
}

function runTestReplaceTags(input, output, actual) {
	document.getElementById(actual).innerHTML = replaceTags(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}