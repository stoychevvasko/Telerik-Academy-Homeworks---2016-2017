// Problem 03: Matrix of Numbers - BGCoder format 
function solve(args) {
    var n = +args,
		i,
		j,
		row,
		result = '';		
    	
    for (i = 0; i < n; i += 1) {
        row = '';
		
        for (j = i + 1; j < n + i + 1; j += 1) {
            row = row + j + ' ';			
        }
		
        row = row.trim() + '\n';
		result += row;		
    }
		
	return result;
}