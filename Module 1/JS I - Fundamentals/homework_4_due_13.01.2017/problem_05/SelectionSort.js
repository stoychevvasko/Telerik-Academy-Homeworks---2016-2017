// Problem 05. Selection Sort - BGCoder format
function solve(args) {
    let myArr = [].slice.apply(args).map(Number);    
    myArr.shift();
    
    for (let i = 0; i < myArr.length; i += 1) {
        let min = i;

        for (let j = i + 1; j < myArr.length; j += 1) {
            if (myArr[j] < myArr[min]) {
                min = j;
            }
        }

        let temp = myArr[i];
        myArr[i] = myArr[min];
        myArr[min] = temp;
    }

    for (var elem of myArr){
        console.log(elem);
    }
}