<?php
// Recebendo valores
$n1 = $_POST["nota1"];
$n2 = $_POST["nota2"];
$n3 = $_POST["nota3"];
$n4 = $_POST["nota4"];

//calculando a média
$media = ($n1 + $n2 + $n3 + $n4) / 4;

// mostrando a média
echo "<strong>Sua média é de: $media</strong>";


?>