<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Vetor</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <?php

    // vetor dinamico
    $vnome = array('Alan', 'Julio', 'Pedro', 'Bruno', 'Camila', 'Everton', 'Tatiane');

    // vetor fixo
    $cidade[0] = 'Franco da Rocha';
    $cidade[1] = 'Caieiras';
    $cidade[2] = 'Mairipora';
    $cidade[3] = 'Fransico Morato';
    $cidade[4] = 'Cajamar';
    $cidade[5] = 'Jundiai';

    // exibir
    foreach  ($vnome as $nome) {
        echo "$nome<br>";
    }    

    for ($i=0; $i < 6; $i++) { 
        echo "$cidade[$i]<br>";
    }

    ?>
</body>
</html>