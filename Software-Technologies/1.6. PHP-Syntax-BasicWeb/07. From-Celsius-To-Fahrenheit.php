<form>
Celsius: <input type="text" name="cel" />
    <input type="submit" value="Convert">
    <?= msgAfterCelsius() ?>
</form>
<form>
    Fahrenheit: <input type="text" name="fah" />
    <input type="submit" value="Convert">
    <?= msgAfterFahrenheit() ?>
</form>

<?php
function msgAfterCelsius(){
    $string = "";
    if (isset($_GET['cel'])){
        $cel = floatval($_GET['cel']);
        $fah = celsiusToFahrenheit($cel);
        $string = "$cel &deg;C = $fah &deg;F";
    }
    return $string;
}

function msgAfterFahrenheit(){
    $string = "";
    if (isset($_GET['fah'])){
        $fah = floatval($_GET['fah']);
        $cel = fahrenheitToCelsius($fah);
        $string = "$fah &deg;F = $cel &deg;C";
    }
    return $string;
}

function celsiusToFahrenheit(float $celsius) : float {
    return $celsius * 1.8 + 32;
}
function fahrenheitToCelsius(float $fahrenheit) : float {
    return ($fahrenheit - 32) / 1.8;
}