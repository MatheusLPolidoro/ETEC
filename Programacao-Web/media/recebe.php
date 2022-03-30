<?php
$primeiro = $_POST['primeiro'];
$segunda = $_POST['segunda'];
$terceira = $_POST['terceira'];
$quarta = $_POST['quarta'];

$media = ($primeiro + $segunda + $terceira + $quarta) / 4;

echo "Sua média é: ".$media;

if($media < 5){
    echo "<br>Situação: Reprovado ";
}
elseif($media > 6){
    echo "<br>Situação: Aprovado ";
}
else{
    echo "<br>Situação: Recuperação ";
}

?>