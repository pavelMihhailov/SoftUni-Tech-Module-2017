function solution(str) {
    for (let i = 0; i < str.length; i++){
        let input = JSON.parse(str[i]);
        console.log(`Name: ${input.name}`);
        console.log(`Age: ${input.age}`);
        console.log(`Date: ${input.date}`);
    }
}