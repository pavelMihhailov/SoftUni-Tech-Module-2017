function solution(input) {
    let dict = [];

    for (let i = 0; i < input.length - 1; i++) {
        let command = input[i].split(" ");
        let key = command[0];
        let value = command[1];

        if (!(key in dict)) dict[key] = [];
        dict[key].push(value);
    }
    let wantedKey = input[input.length - 1];

    if (!(wantedKey in dict)) console.log("None");
    else console.log(dict[wantedKey].join("\n"));
}