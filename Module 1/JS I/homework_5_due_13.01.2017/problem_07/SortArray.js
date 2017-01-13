// Problem 07. Sorting array - BGCoder format
function sortingArray(args) {
	let count = +args[0],
		arr = args[1].split(' ').map(Number);
	
	function MaximalElement(arr, startIndex) {
        let maxElement = arr[startIndex],
			maxElementIndex;
			
        for (let i = startIndex + 1; i < arr.length; i += 1) {
            if (arr[i] > maxElement) {
                maxElement = arr[i];
                maxElementIndex = i;
            }
        }
        return maxElementIndex;
    }

    function SortDescending(arr) {
        for (let i = 0; i < arr.length - 1; i += 1) {
            let tmp = arr[i],
				largestNumIndex = MaximalElement(arr, i);

            if (largestNumIndex > 0) {
                arr[i] = arr[largestNumIndex];
                arr[largestNumIndex] = tmp;
            }
        }

        return arr;
    }

    function SortAscending(arr) {
        SortDescending(arr);
		
        for (let i = 0; i < Math.floor(arr.length / 2); i += 1) {
            let tmp = arr[i];
            arr[i] = arr[arr.length - 1 - i];
            arr[arr.length - 1- i] = tmp;
        }
		
        return arr;
    }

	let result = SortAscending(arr).join(' ');	
	return (result);
}