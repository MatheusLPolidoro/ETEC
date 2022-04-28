<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercicios</title>
    <link rel="stylesheet" href="style.css">
</head>
<style>
    table {
        width: 50%;
    }
</style>
<body>
<a class="voltar" href="index.php">&#8617;</a>
    <h1>EXERCÍCIO 4</h1>
    <p>Programa que exibe todos os números de 1 a 500 e destaca os múltiplos de <strong>3 (FIZZ)</strong>, <strong> 5 (BUZZ)</strong> e de ambos <strong>3 (FIZZBUZZ)</strong></p>
    <hr>
    <table>
    <?php
        for ($i = 1; $i <= 500; $i++)
        {
            echo "<tr>";
            if ((!($i % 3) && !($i % 5)))
            {
                echo "<td>FizzBuzz</td>";
            }
            elseif (!($i % 3))
            {
                echo "<td>Fizz</td>";
            }
            elseif (!($i % 5))
            {
                echo "<td>Buzz</td>";
            }
            else
            {
                echo "<td></td>";
            }
            echo "<td>" . str_pad($i, 3, '0', STR_PAD_LEFT) . "</td></tr>";
        }
    ?>
    </table>
</body>
</html>