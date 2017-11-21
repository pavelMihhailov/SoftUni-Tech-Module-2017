<form>
    <input type="text" name="num1">
    <input type="text" name="num2">
    <input type="text" name="num3">
    <input type="submit">
</form>
<?php
$negativesCount = 0;

if (isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])) {
    $number1 = intval($_GET['num1']);
    $number2 = intval($_GET['num2']);
    $number3 = intval($_GET['num3']);
    $isFound = false;

    if ($number1 == 0 || $number2 == 0 || $number3 == 0){
        echo "Positive";
        $isFound = true;
    }
    else if ($number1 < 0) $negativesCount++;
    else if ($number2 < 0) $negativesCount++;
    else if ($number3 < 0) $negativesCount++;
    if ($isFound == false){
        if ($negativesCount % 2 == 0) echo "Positive";
        else echo "Negative";
    }
}
?>