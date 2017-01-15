// Problem 04: Parse tags - BGCoder format
function solve(args) {
	let text = args[0],
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
					// toUpperEnabled = false;
					// toLowerEnabled = false;					
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
					if (!toLowerEnabled) {
						toUpperEnabled = true;
					}					
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
					if (!toUpperEnabled) {
						toLowerEnabled = true;
					}
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
	return result;
}