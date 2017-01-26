// Problem 06. Frequent Number - BGCoder format
function solve(args) {
	var result = "";	
	let arr = args.map(Number);
    arr.shift();

    let frequency = {};
    let maxFrequency = 0;
    let maxElement; 

    for (let num in arr) {        
        frequency[arr[num]] = (frequency[arr[num]] || 0) + 1;
        if (frequency[arr[num]] > maxFrequency) {
            maxFrequency = frequency[arr[num]];
            maxElement = arr[num];
        }
    }
    
	result = (maxElement + ' (' + maxFrequency + ' times)');	
	return result;
}
