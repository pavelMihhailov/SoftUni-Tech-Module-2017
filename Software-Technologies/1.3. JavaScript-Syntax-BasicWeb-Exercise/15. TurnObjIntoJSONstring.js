function solution(str) {
    let obj = {};

    for (let i = 0; i < str.length; i++){
        let input = str[i].split(" -> ");
        let key = input[0];
        let value = input[1];
        if (!isNaN(value)) value = Number(value);
        obj[key] = value;
    }
    console.log(JSON.stringify(obj));
}