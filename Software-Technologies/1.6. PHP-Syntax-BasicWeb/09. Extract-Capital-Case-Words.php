<form>
    <textarea rows="10" name="text"></textarea><br>
    <input type="submit" value="Extract"/>
</form>

<?php
function resultList(){
if (isset($_GET['text'])){
    $text = $_GET['text'];
    preg_match_all('/\w+/', $text, $matchedWords);
    $matchedWords = $matchedWords[0];
    $upperWords = array_filter($matchedWords, function($word){
        return strtoupper($word) == $word;
    });
    echo implode(', ', $upperWords);
}
}
?>

<form>
    <textarea rows="10" name="text"><?=resultList()?></textarea>
</form>
