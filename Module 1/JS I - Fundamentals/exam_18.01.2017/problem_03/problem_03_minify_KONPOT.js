function solve(args) {
	let input = args,
		count = args.length,
		result = [];
	
	for (let i = 0; i < count; i += 1) {
		let trimmedLine = input[i].trim();
		result.push(trimmedLine);
	}
	
	result = result.join('');
	
	result = result.split(' ').join('');
	//result = result.split(';;').join(';');
	result = result.split('{}').join('');
	
	let numberOfIdentifiers = result.split(/[;{}]/).length,
		allIdentifiers = result.split(/[;{}]/); 		
	
	let splitterCounter = 0,
		splittersArray = [];
	for (let i = 0; i < result.length; i += 1) {
		if (result[i] === ';') {
			splitterCounter += 1;
			splittersArray.push(result[i]);
			continue;
		}
		
		if (result[i] === '{') {
			splitterCounter += 1;
			splittersArray.push(result[i]);
			continue;
		}
		
		if (result[i] === '}') {
			splitterCounter += 1;
			splittersArray.push(result[i]);
			continue;
		}
	}
	
	for(let i = allIdentifiers.length - 1; i >= 0; i--) {
		if(allIdentifiers[i] === '') {
		allIdentifiers.splice(i, 1);
		}
    }
	
	result = result.split(/[{};]+/).filter(x => (x != ''));
	
	function removeDuplicates(arr) {
		var obj = {};
		var ret_arr = [];
		for (var i = 0; i < arr.length; i++) {
			obj[arr[i]] = true;
		}
		for (var key in obj) {
			ret_arr.push(key);
		}
		return ret_arr;
	}
	
	result = removeDuplicates(result);
	
	let numberOfUniqueIdentifiers = result.length,
		finalResult;
	
	if (numberOfUniqueIdentifiers <= 62) {
		finalResult = numberOfUniqueIdentifiers + splittersArray.length;		
	} else {
		finalResult = numberOfUniqueIdentifiers + numberOfUniqueIdentifiers + splittersArray.length;		
	}
	
	return (finalResult);
}

console.log(solve(
[
    'hello;',
    '{this; is',
    ' ; an;;;example;',
    '}',
    'of;',
    '{',
    'KONPOT;',
    '{',
    'Some_numbers;',
    '42;5;3}',
    '_}'
]
));

// 24
console.log('-----------------');

console.log(solve(
[
    '; ;;;jGefn4E5Pvq    ;;  ;  ; ;',
    'tQRZ5MMj26Ov { {    {;    ;;    5OVyKBFu7o1T2 ;szDVN2dWhex1V;1gDdNdANG2',
    ';    ;    ;  ;; jGefn4E5Pvq   ;;    ;p0OWoVFZ8c;;}    ;  ; ;',
    '5OVyKBFu7o1T2   ;  szDVN2dWhex1V ;    ;tQRZ5MMj26Ov    ;  ;   };',
    '1gDdNdANG2    ;   p0OWoVFZ8c ;  jGefn4E5Pvq ;; {;Z9n;;',
    ';1gDdNdANG2;   ;;    ;   ;jGefn4E5Pvq    ;; ;;p0OWoVFZ8c;;    ;;',
    ';',
    'tQRZ5MMj26Ov  ;',
    '{    ;szDVN2dWhex1V;   ;',
    ';   jGefn4E5Pvq   ;  ;  } }}'
]
));

// 44
console.log('-----------------');

console.log(solve(
[
    '1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11; 12; 13; 14;',
    '15; 16; 17; 18; 19; 20; 21; 22; 23; 24; 25; 26; 27; 28;',
    '29; 30; 31; 32; 33; 34; 35; 36; 37; 38; 39; 40; 41; 42;',
    '43; 44; 45; 46; 47; 48; 49; 50; 51; 52; 53; 54; 55; 56;',
    '57; 58; 59; 60; 61; 62; 63; 64; 65; 66; 67; 68; 69; 70;'
]
));

// 146
console.log('-----------------');