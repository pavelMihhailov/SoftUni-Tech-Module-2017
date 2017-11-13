function solution(nums) {
    let negativeNums = 0;
    let zeros = 0;
    nums.map(Number);

    for (let i = 0; i < nums.length; i++){
        if (nums[i] < 0)
            negativeNums++;
        if (nums[i] == 0)
            zeros++;
    }

    if (negativeNums % 2 !== 0){
        if (zeros > 0) console.log("Positive");
        else console.log("Negative");
    }
    else console.log("Positive");
}