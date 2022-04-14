<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercicios</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>

    <a class="voltar" href="index.php">&#8617;</a>
    <h1>EXERCÍCIO 1</h1>
    <p>Programa que exibe todos os números múltiplos de 5 <strong>e</strong> 9 de <strong>1000</strong> até <strong>10000</strong></p>
    <hr>
    <?php
        $coluna = 1;
        for ($i = 1000; $i <= 10000; $i++)
        {
            if (!($i % 5) && !($i % 9))
            {
                echo "<span class = 'valor'>$i</span>";
                if ($coluna == 10)
                {
                    echo "<br>";
                    $coluna = 0;
                }

                $coluna ++;
            }
        }
    
    ?>

</body>
</html>