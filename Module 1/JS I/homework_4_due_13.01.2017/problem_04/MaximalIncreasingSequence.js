// Problem 04. Maximal Increasing Sequence - BGCoder format

function solveProblem(args) {
    let myArr = [].slice.apply(args).map(Number);
    let maxSeq = 1;
    let currentSeq = 0;
    let prevNumber = 0;

    for (let i = 0; i < myArr.length - 1; i += 1 ) {
        if (myArr[i] > prevNumber) {
            currentSeq += 1;
        }
        else {
            currentSeq = 1;
        }

        if (currentSeq > maxSeq) {
            maxSeq = currentSeq;
        }
		
        prevNumber = myArr[i];
    }

    return (maxSeq);
}