function solution(input) {
    let resultArr = [];
    resultArr.length = Number(input[0]);

    for (let i = 0; i < resultArr.length; i++){
        resultArr[i] = 0;
    }

    for (let i = 1; i < input.length; i++) {
        let splittedInput = input[i].split(" - ");
        let index = Number(splittedInput[0]);
        let value = Number(splittedInput[1]);
        resultArr[index] = value;
    }
    console.log(resultArr.join("\n"));
}