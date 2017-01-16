// Problem 04: Parse tags - BGCoder format
function solve(args) {
    var text = args[0],
        inTag = false,
        currentTag = '',
        tags = [],
        result = [];

    for (var i = 0; i < text.length; i++) {
        if (text[i] === '<') {
            inTag = true;
        } else if (text[i] === '>' && inTag) {
            inTag = false;
            currentTag += text[i];
            tags.push(currentTag);
            currentTag = '';
        } else if (!inTag) {
            if (tags.length === 0) {
                result.push(text[i]);
            } else if (tags[tags.length - 1].indexOf('upcase') !== -1) {
                result.push(text[i].toUpperCase());
            } else if (tags[tags.length - 1].indexOf('lowcase') !== -1) {
                result.push(text[i].toLowerCase());
            } else {
                result.push(text[i]);
            }
        }

        if (inTag || text[i] === '>') {
            currentTag += text[i];
        }

        if (tags.length !== 0 && tags[tags.length - 1].indexOf('</') !== -1) {
            tags.pop();
            tags.pop();
        }
    }

    return (result.join(''));    
}