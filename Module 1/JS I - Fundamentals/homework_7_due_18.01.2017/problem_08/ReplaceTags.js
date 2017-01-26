// Problem 08. Replace tags - BGCoder format
function solve(args) {
	let input =  args[0].split('<a href='),
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
	
	return result;
}

var test = [ '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>' ];
console.log(solve(test));