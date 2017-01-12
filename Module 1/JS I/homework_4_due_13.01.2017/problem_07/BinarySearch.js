// Problem 07. Binary Search - BGCoder format
function solve(args) {
	var result = "";	
	let arr = [].slice.apply(args).map(Number);
    arr.shift();
    
    let soughtNum = arr.pop();

    arr.sort(function(a, b) {return a-b;});

    var isExisting = false;

    for (let i = 0; i < arr.length; i += 1) {
        if (arr[i] == soughtNum) {
            isExisting = true;
        }
    }

    if (!isExisting) {
        result = -1;
    } 
	else {
        let imin = 0;
        let imax = arr.length;

        while (imax >= imin) {
            let imid = imin + Math.floor((imax - imin) / 2);

            if (arr[imid] === soughtNum) {
                result = (imid.toString());
                break;
            }
            else if (arr[imid] < soughtNum) {
                imin = imid + 1;
            }
            else {
                imax = imid - 1;
            }
        }
    }	
	
	return result;
}