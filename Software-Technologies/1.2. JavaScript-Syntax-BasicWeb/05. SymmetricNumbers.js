function solution(arr) {
    let num = Number(arr[0]);
    let result = [];
    for (let i = 1; i <= num; i++){
        if (i.toString() === i.toString().split("").reverse().join("")){
            result.push(i);
        }
    }
    console.log(result.join(" "));
}