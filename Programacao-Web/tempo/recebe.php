<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Resultado</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <?php 

    $tempo = $_POST["tempo"];
    $medida = $_POST["medida"];

    switch ($medida)
    {
        case "dia_hora":
            $temp = "$tempo dia(s) convertidos para horas é igual:";
            $tempo_convertido = 24 * $tempo . " h";  
            break;
        case "hora_minuto":
            $temp = "$tempo hora(s) convertidos para minutos é igual:";
            $tempo_convertido = 60 * $tempo . " m";
            break;
        case "minuto_segundo":
            $temp = "$tempo minuto(s) convertidos para segundos é igual:";
            $tempo_convertido = 60 * $tempo . " s";
            break;
    }
    ?>
    <a href="index.php">&#8617;</a>
    <h1>RESULTADO</h1>
    <form>
        <span><?php echo $temp ?></span>
        <span><?php echo $tempo_convertido ?></span>
    </form>
</body>
</html>
