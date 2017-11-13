function solution(arr) {
    let text = arr.join(",");
    let words = text.split(/\W+/)
    let correctWords = words.filter(w => w.length > 0);
    let rightWords = correctWords.filter(isUpperCase);
    console.log(rightWords.join(", "));

    function isUpperCase(str) {
        return str === str.toUpperCase();
    }
}