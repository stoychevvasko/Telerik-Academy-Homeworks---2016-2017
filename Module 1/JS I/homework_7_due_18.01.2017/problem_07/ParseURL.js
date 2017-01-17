// Problem 07. Parse URL - BGCoder format
function solve(args) {
	let input = args[0],
		protocol = input.split(':')[0],		
		server = input.split('/')[2],
		resource = input.split(server)[1],
		result = '';
	
	result += ('protocol: ' + protocol + '\n');
	result += ('server: ' + server + '\n');
	result += ('resource: ' + resource + '\n');	
	
	return result;
}