// Problem 06. Extract text from HTML - BGCoder format
function solve(args) {
    let matchTags = /<.*?>/ig,
		result = '';     

    for (let line of args) {
        result += line.replace(matchTags, '').trim();
    }

    return result;
}