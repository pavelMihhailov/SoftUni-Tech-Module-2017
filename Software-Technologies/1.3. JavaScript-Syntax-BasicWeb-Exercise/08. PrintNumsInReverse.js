function print(nums){
    let result = [];
    for (let i = 0; i < nums.length; i++){
        result.push(nums[i]);
    }
    result.reverse();

    console.log(result.join("\n"));
}
