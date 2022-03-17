<?php
$medida = $_POST["medida"];

$milimetro = $medida * 10;
$centimetro = $medida * 100;
$metro = $medida * 1000;

echo "Centimetro para Milímetro " . number_format($medida, 2, ",", ".") .  " Centímetros são " . number_format($milimetro, 2, ",", ".") . " Milímetros<br>"; 
echo "Metro para Centímetro " . number_format($medida, 2, ",", ".") .  " Metros são " . number_format($centimetro, 2, ",", ".") . " Centímetros<br>";
echo "Quilômetro para Metro " . number_format($medida, 2, ",", ".") .  " Quilômetro são " . number_format($centimetro, 2, ",", ".") . " Metros<br>"; 
?>