// Problem 06: Quadratic Equation - BGCoder format
function solve(args) {
	var a = +args[0],
		b = +args[1],
		c = +args[2],
		determinant = +(b * b - 4 * a * c);		
		
	if (determinant < 0) {
		var result = ('no real roots');		
		return result;
	}
	
	if (determinant == 0) {
		var result = ('x1=x2=' + (-b / (2 * a)).toFixed(2));		
		return result;
	}
	
	if (determinant > 0) {
		var x1 = (((Math.sqrt(determinant)) - b) / (2 * a)).toFixed(2),
			x2 = (((-Math.sqrt(determinant)) - b) / (2 * a)).toFixed(2);
				
		if (x1 > x2) {
			if ((x1 > 0) || (x2 > 0)) {
				var temp = x1,
					x1 = x2,
					x2 = temp;
			}
		}
		
		if ((x1 < 0) && (x2 < 0)) {
			var temp1 = x1,
				x1 = x2,
				x2 = temp1;
		}
		
		var result = ('x1=' + x1 + '; x2=' + x2);		
		return result;
	}
}