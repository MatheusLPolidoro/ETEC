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
    <h1>EXERCÍCIO 2</h1>
    <p>Programa que exibe todos os números de 1 a 100 e destaca os múltiplos de <strong>10</strong></p>
    <hr>
    <table>
        <?php
            $coluna = 1;
            echo "<tr>";
            for ($i = 1; $i <= 100; $i++)
            {
                if ($coluna == 10)
                {
                    echo "<td class='destaque'>MÚLTIPLO&nbsp;DE&nbsp;10&#x27A1;</td>";
                    echo "<td class='destaque'><strong>".str_pad($i, 3, '0', STR_PAD_LEFT)."</strong></td></tr>";
                    $coluna = 0;
                }
                else
                {
                    echo "<td>". str_pad($i, 3, '0', STR_PAD_LEFT) . "</td>";
                }

                $coluna ++;
            }
        ?>
    </table>
</body>
</html>