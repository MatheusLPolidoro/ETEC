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
    <h1>EXERCÍCIO 6</h1>
    <p>Programa que gera 100 números aleatórios de 1 a 100 e exibe: <strong>QUANTIDADE PARES E ÍMPARES, MAIOR, SOMA E MÉDIA</strong></p>
    <hr>
    <input type="button" class="botao-atualizar" value="SORTEAR" onClick="window.location.reload()">
    <table>
    <?php
        $coluna = 1;
        echo "<tr>";
        for ($i = 1; $i <= 100; $i++)
        {
            $sorteio = rand(1,100);
            if ($coluna == 10)
            {
                echo "<td>".str_pad($sorteio , 3, '0', STR_PAD_LEFT)."</td>";
                echo "</tr>";
                $coluna = 0;
            }
            else
            {
                echo "<td>". str_pad($sorteio , 3, '0', STR_PAD_LEFT) . "</td>";
            }

            $coluna ++;
        }
        

    ?>
    </table>
</body>
</html>