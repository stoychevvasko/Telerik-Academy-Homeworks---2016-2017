// Problem 02: MMSA (Min, Max, Sum, Average) of N Numbers - BGCoder format
function solve(args) {
	var arr = args.map(Number);
	let min = arr[0],
		max = arr[0],
		sum = 0,
		avg = 0;
	
	for (var i = 0; i < arr.length; i += 1) {
		if (min > arr[i]) {
			min = arr[i];
		}
		
		if (max < arr[i]) {
			max = arr[i]
		}
		
		sum += arr[i];
	}
	
	avg = sum / arr.length;
	
	var result = "min=" + min.toFixed(2) + "\n" + 
				 "max=" + max.toFixed(2) + "\n" + 
				 "sum=" + sum.toFixed(2) + "\n" + 
				 "avg=" + avg.toFixed(2);
	
	return (result);
}