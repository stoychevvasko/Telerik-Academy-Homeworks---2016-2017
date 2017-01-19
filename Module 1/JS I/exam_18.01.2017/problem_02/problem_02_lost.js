function solve(args) {	
	let R = args[0].split(' ')[0],
		C = args[0].split(' ')[1],
		maze = [],
		result;
		
	for (let i = 1; i <= R; i += 1) {
		let thisRow = args[i].split(' ').map(Number);
		maze.push(thisRow);
	}
		
	function canMoveRight(num) {
		if (num === 0) {
			return false;
		}			
		
		return ((((num >> 1) & 1) === 1) ? true : false);
	}
	
	function isRightMovePossible(currentRow, currentCol, maze) {
		if (canMoveRight(maze[currentRow][currentCol])) {
			if (hasEscaped(currentRow, currentCol + 1, maze)) {
				return true;
			} else {
				if (maze[currentRow][currentCol + 1] === 0) {
					return false;
				} else {
					return true;
				}
			}
		} else {
			return false;
		}
	}
	
	function canMoveLeft(num) {
		if (num === 0) {
			return false;
		}			
				
		return ((((num >> 3) & 1) === 1) ? true : false);
	}
	
	function isLeftMovePossible(currentRow, currentCol, maze) {
		if (canMoveLeft(maze[currentRow][currentCol])) {
			if (hasEscaped(currentRow, currentCol - 1, maze)) {
				return true;
			} else {
				if (maze[currentRow][currentCol - 1] === 0) {
					return false;
				} else {
					return true;
				}
			}
		} else {
			return false;
		}
	}
	
	function canMoveUp(num) {
		if (num === 0) {
			return false;
		}			
		
		return (((num & 1) === 1) ? true : false);
	}
	
	function isUpMovePossible(currentRow, currentCol, maze) {
		if (canMoveUp(maze[currentRow][currentCol])) {
			if (hasEscaped(currentRow - 1, currentCol, maze)) {
				return true;
			} else {
				if (maze[currentRow - 1][currentCol] === 0) {
					return false;
				} else {
					return true;
				}
			}
		} else {
			return false;
		}
	}
	
	function canMoveDown(num) {
		if (num === 0) {
			return false;
		}			
		
		return ((((num >> 2) & 1) === 1) ? true : false);
	}
	
	function isDownMovePossible(currentRow, currentCol, maze) {
		if (canMoveDown(maze[currentRow][currentCol])) {
			if (hasEscaped(currentRow + 1, currentCol, maze)) {
				return true;
			} else {
				if (maze[currentRow + 1][currentCol] === 0) {
					return false;
				} else {
					return true;
				}
			}
		} else {
			return false;
		}
	}
	
	function hasEscaped(rowValue, colValue, maze) {
		let maxRow = maze.length,
			maxCol = maze[0].length;
		
		if (rowValue < 0 || colValue < 0)
		{
			return true;
		}
		
		if (rowValue >= maxRow || colValue >= maxCol) {
			return true;
		}
		
		return false;
	}
		
	let startingRow = (R / 2).toFixed(0) - 1,
		startingCol = (C / 2).toFixed(0) - 1,
		row = startingRow,
		col = startingCol
		prevRow = row,
		prevCol = col;
	
	
	while (true) {
		
		if (hasEscaped(row, col, maze)) {
			// escaped, won, game over
			return ('No rakiya, only JavaScript ' + prevRow + ' ' + prevCol);
		}
		
		let currentNumber = maze[row][col];
		
		
		if (isUpMovePossible(row, col, maze)) {			
			// move up
			maze[row][col] = 0;
			prevRow = row;
			prevCol = col;
			row -= 1;
			continue;
		} else if (isRightMovePossible(row, col, maze)) {
			// move right
			maze[row][col] = 0;
			prevRow = row;
			prevCol = col;
			col += 1;
			continue;
		} else if (isDownMovePossible(row, col, maze)) {
			// move down
			maze[row][col] = 0;
			prevRow = row;
			prevCol = col;
			row += 1;
			continue;
		} else if (isLeftMovePossible(row, col, maze)) {
			// move left
			maze[row][col] = 0;
			prevRow = row;
			prevCol = col;
			col -= 1;
			continue;
		} else {
			// lost, game over
			return ('No JavaScript, only rakiya ' + row + ' ' + col);
		}		
	}
	
		
	return ('invalid_result');
}

console.log(solve(
[
    '5 7',
    '9 5 3 11 9 5 3',
    '10 11 10 12 4 3 10',
    '10 10 12 7 13 6 10',
    '12 4 3 9 5 5 2',
    '13 5 4 6 13 5 6'
]
));

// No rakiya, only JavaScript 0 1

console.log(solve(
[
    '7 5',
    '9 3 11 9 3',
    '10 12 4 6 10',
    '12 3 13 1 6',
    '9 6 11 12 3',
    '10 9 6 13 6',
    '10 12 5 5 3',
    '12 5 5 5 6'
]
));

// No JavaScript, only rakiya 1 2

