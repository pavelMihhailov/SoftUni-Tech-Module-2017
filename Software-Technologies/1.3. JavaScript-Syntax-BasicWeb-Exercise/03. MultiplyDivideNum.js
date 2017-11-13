function solution(nums) {
    [num1, num2] = nums.map(Number)
    if (num1 <= num2){
        return num1 * num2;
    }
    else
        return num1 / num2;
}