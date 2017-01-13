// Problem 01: Planar coordinates - BGCoder format
function solve(args) {	
	let arr = args.map(Number);		
	
	function createPoint(x, y) {
		return {
			X : x,
			Y : y
		}
	}
	
	function createLine(start, end) {
		return {
			Start : start,
			End : end,
			calculateLength : function() {
				let result = Math.sqrt(
								Math.pow((this.End.X - this.Start.X), 2) + 
								Math.pow((this.End.Y - this.Start.Y), 2)
							);
				return result;
			}
		}
	}
	
	function isTrianglePossible(lineOne, lineTwo, lineThree) {
		let lengthOne = lineOne.calculateLength(),
			lengthTwo = lineTwo.calculateLength(),
			lengthThree = lineThree.calculateLength();
		
		return (
			(lengthOne + lengthTwo > lengthThree) && 
			(lengthOne + lengthThree > lengthTwo) && 
			(lengthTwo + lengthThree > lengthOne)
		);
	}
	
	let startFirstLine = createPoint(arr[0], arr[1]),
		endFirstLine = createPoint(arr[2], arr[3]),
		startSecondLine = createPoint(arr[4], arr[5]),
		endSecondLine = createPoint(arr[6], arr[7]),
		startThirdLine = createPoint(arr[8], arr[9]),
		endThirdLine = createPoint(arr[10], arr[11]);
	
	let firstLine = createLine(startFirstLine, endFirstLine),
		secondLine = createLine(startSecondLine, endSecondLine),
		thirdLine = createLine(startThirdLine, endThirdLine);
	
	let firstLength = firstLine.calculateLength(),
		secondLength = secondLine.calculateLength(),
		thirdLength = thirdLine.calculateLength();
	
	let result = [
		firstLength.toFixed(2), 
		secondLength.toFixed(2), 
		thirdLength.toFixed(2), 
		((isTrianglePossible(firstLine, secondLine, thirdLine)) ? 'Triangle can be built' : 'Triangle can not be built')
	];
	
	result = result.join('\n');		
	return result;
}