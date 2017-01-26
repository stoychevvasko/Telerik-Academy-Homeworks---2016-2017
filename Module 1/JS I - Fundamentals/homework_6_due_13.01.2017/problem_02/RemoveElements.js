// Problem 02: Remove elements - BGCoder format
function solve(args) {
    let arr = args,
		result = '';	
	
	Array.prototype.removeElement = function(element) {
        var index = this.indexOf(element);
		
        while(index > -1) {
            this.splice(index, 1);
            index = this.indexOf(element);
        }
		
        return this;
    };

    result = arr.removeElement(arr[0]).join('\n');	
	return result;
}