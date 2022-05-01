<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercicios</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<style>
    table {
        width: 20%;
    }

    td {
        padding: 5px 20px 5px 20px;
    }

    .tabelas {
        margin-top: 0px;
        display: flex;
    }
</style>

<body>
    <header>
        <a class="voltar" href="index.php">&#8617;</a>
        <h1>EXERCÍCIO 6</h1>
    </header>
    <div>
        <p>Programa que gera 100 números aleatórios de 1 a 100 e exibe: <strong>QUANTIDADE PARES E ÍMPARES, MAIOR, SOMA E MÉDIA</strong></p>
        <hr>
        <div class="tabelas">
            <input type="button" class="botao-atualizar" value="&#x1F3B2;" onClick="window.location.reload()">
            <table>
                <th colspan=10>SORTEIO</th>
                <?php
                $coluna = 1;
                $qtd = 100;
                $soma = $impar = $maior = 0;

                echo "<tr>";
                for ($i = 1; $i <= $qtd; $i++) {
                    $sorteio = rand(1, $qtd);
                    if ($sorteio % 2) {
                        $impar++;
                    }
                    if ($sorteio > $maior) {
                        $maior = $sorteio;
                    }

                    $soma += $sorteio;

                    if ($coluna == 10) {
                        echo "<td>" . str_pad($sorteio, 3, '0', STR_PAD_LEFT) . "</td>";
                        echo "</tr>";
                        $coluna = 0;
                    } else {
                        echo "<td>" . str_pad($sorteio, 3, '0', STR_PAD_LEFT) . "</td>";
                    }
                    $coluna++;
                }
                $media = $soma / $qtd;
                ?>
            </table>
            <table>
                <th>DESCRIÇÃO</th>
                <th>RESULTADO</th>
                <tr>
                    <td>PAR</td>
                    <td><?php echo $qtd - $impar; ?></td>
                </tr>
                <tr>
                    <td>ÍMPAR</td>
                    <td><?php echo $impar; ?></td>
                </tr>
                <tr>
                    <td>MAIOR</td>
                    <td><?php echo $maior; ?></td>
                </tr>
                <tr>
                    <td>SOMA</td>
                    <td><?php echo $soma; ?></td>
                </tr>
                <tr>
                    <td>MÉDIA</td>
                    <td><?php echo $media; ?></td>
                </tr>
            </table>
        </div>
    </div>
</body>

</html>