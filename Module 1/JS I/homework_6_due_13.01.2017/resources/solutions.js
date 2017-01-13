function runScript() {
	console.log('SAMPLE TEST RESULTS');
	console.log('===============================================');
	runTestPlanarCoordinates('P01_I01', 'P01_O01', 'P01_A01');
	runTestPlanarCoordinates('P01_I02', 'P01_O02', 'P01_A02');
	console.log('===============================================');
	runTestRemoveElements('P02_I01', 'P02_O01', 'P02_A01');
	runTestRemoveElements('P02_I02', 'P02_O02', 'P02_A02');
	console.log('===============================================');
	runTestYoungestPerson('P03_I01', 'P03_O01', 'P03_A01');
	runTestYoungestPerson('P03_I02', 'P03_O02', 'P03_A02');
	console.log('===============================================');
}

function convertToJSON(args) {	
	var input = args;
    var rawJSON = '[' + input.replace(/'/g, "\"") + ']';
    var arr = JSON.parse(rawJSON);
	return arr;
}

// Problem 01: Planar Coordinates
function planarCoordinates(args) {
	let arr = convertToJSON(args)[0].map(Number),
		result = '';
	
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
				return result.toFixed(2);
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
	
	result = [
		firstLength, 
		secondLength, 
		thirdLength, 
		((isTrianglePossible(firstLine, secondLine, thirdLine)) ? 'Triangle can be built' : 'Triangle can not be built')
	];
	
	let resultForConsole = result.join('\n');
	
	result = '<p>' + result.join('</p><p>') + '</p>';
	
	console.log('Problem 01:\n' + resultForConsole);
	return result;
}

function runTestPlanarCoordinates(input, output, actual) {
	document.getElementById(actual).innerHTML = planarCoordinates(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 02. Remove elements
function removeElements(args) {
	let arr = convertToJSON(args)[0],
		result = '';	
	
	Array.prototype.removeElement = function(element) {
        var index = this.indexOf(element);
		
        while(index > -1) {
            this.splice(index, 1);
            index = this.indexOf(element);
        }
		
        return this;
    };

    result = arr.removeElement(arr[0]);
	let resultForConsole = result.join('\n');
	
	console.log('Problem 02:\n' + resultForConsole);
	result = '<p>' + result.join('</p><p>') + '</p>';
	return result;
}

function runTestRemoveElements(input, output, actual) {
	document.getElementById(actual).innerHTML = removeElements(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}

// Problem 03. Youngest person
function getYoungestPerson(args) {	
    var input = convertToJSON(args)[0];
    var people = [];
	var result = '';
  
    function constructPerson(firstName, lastName, age) {
        return {
            firstname: firstName,
            lastname: lastName,
            age: parseInt(age)
        };
    }
  
    function getYoungest(people) {
        var youngestPerson = people[0];
        for (var i = 1; i < people.length; i += 1) {
            if (people[i].age < youngestPerson.age) {
                youngestPerson = people[i];
            }
        }
        return youngestPerson;
    }
     
    while(input.length > 0) {
        var person = constructPerson.apply(this, (input.slice(0, 3)));
        people.push(person);
        input.splice(0, 3);
    }
 
    youngestPerson = getYoungest(people);
	result = youngestPerson.firstname + ' ' + youngestPerson.lastname
    
	console.log('Problem 03:\n' + result);
	return result;
}

function runTestYoungestPerson(input, output, actual) {
	document.getElementById(actual).innerHTML = getYoungestPerson(document.getElementById(input).innerHTML);
	if (!((document.getElementById(actual).innerHTML) === (document.getElementById(output).innerHTML))) {
		document.getElementById(actual).className += ' incorrect';
	} else {
		document.getElementById(actual).className += ' correct';
	}
}
