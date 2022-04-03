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

    $peso = $_POST["peso"];
    $altura = $_POST["altura"];

    $imc = $peso / ($altura * $altura);

    if ($imc < 18.5)
    {
        $condicao = "MAGREZA";
    }
    elseif ($imc >= 18.5 && $imc <= 24.9)
    {
        $condicao = "NORMAL";
    }
    elseif ($imc >= 25 && $imc <= 29.9)
    {
        $condicao = "SOBREPESO";
    }
    elseif ($imc >= 30 && $imc <= 39.9)
    {
        $condicao = "OBESIDADE";
    }
    else
    {
        $condicao = "OBESIDADE GRAVE";
    }
    ?>
    <a href="index.php">&#8617;</a>
    <h1>RESULTADO</h1>
    <form>
        <span>IMC: <?php echo number_format($imc, 2, ',', '') ?></span><br>
        <span>Condição: <?php echo $condicao ?></span>
    </form>
</body>
</html>
