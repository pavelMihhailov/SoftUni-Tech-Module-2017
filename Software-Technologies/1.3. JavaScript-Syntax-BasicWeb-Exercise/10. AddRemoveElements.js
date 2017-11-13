function solution(input){
    let array = [];

    for (let i = 0; i < input.length; i++){
        let format = input[i].split(' ');
        let command = format[0];

        if (command === "add"){
            let number = format[1];
            array.push(number);
        }
        else{
            let index = format[1];
            array.splice(index, 1);
        }
    }
    console.log(array.join("\n"));
}