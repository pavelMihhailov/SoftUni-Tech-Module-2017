<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if (isset($_GET['num'])){
    $num = intval($_GET['num']);
    $fibarray = [1, 1, 2];
    for ( $i=3; $i < $num; $i++) {
        $result = intval($fibarray[$i-1]) + intval($fibarray[$i-2]) + intval($fibarray[$i-3]);
        array_push($fibarray, $result);
    }
    foreach ($fibarray as $item) echo "$item ";
}
?>
</body>
</html>