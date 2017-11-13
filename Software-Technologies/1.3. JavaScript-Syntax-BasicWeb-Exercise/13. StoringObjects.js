function store(input){
    for (let i = 0; i < input.length; i++){
        let mainInput = input[i].split(" -> ");
        let obj = {name: mainInput[0], age: mainInput[1], grade: mainInput[2]};
        console.log(`Name: ${obj.name}`);
        console.log(`Age: ${obj.age}`);
        console.log(`Grade: ${obj.grade}`);
    }
}