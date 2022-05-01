<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercicios</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<style>
    [data-tooltip] {
        position: relative;
        font-weight: bold;
        transition: all ease 0.2s;
    }

    [data-tooltip]:after {
        display: none;
        position: absolute;
        border-radius: 100%;
        font-size: 15px;
        width: 20px;
        height: 20px;
        top: calc(-15%);
        left: calc(-5%);
        content: attr(data-tooltip);
        white-space: nowrap;
        background-color: #00dd2a;
        color: White;
        transition: all ease 0.2s;
    }

    [data-tooltip]:hover:after {
        z-index: 98;
        display: block;
        transition: all ease 0.2s;
    }

    td {
        font-size: 1em;
    }
</style>

<body>
    <header>
        <a class="voltar" href="index.php">&#8617;</a>
        <h1>EXERCÍCIO 1</h1>
    </header>
    <div>
        <p>Programa que exibe todos os números múltiplos de 5 <strong>e</strong> 9 de <strong>1000</strong> até <strong>10000</strong></p>
        <hr>
        <table>
            <?php
            $coluna = 1;
            echo "<tr>";
            for ($i = 1000; $i <= 10000; $i++) {

                if (!($i % 9) && !($i % 5)) {
                    echo "<td data-tooltip='&#x2714'>" . str_pad($i, 4, '0', STR_PAD_LEFT) . "</td>";
                    if ($coluna == 20) {
                        echo "</tr><tr>";
                        $coluna = 0;
                    }

                    $coluna++;
                }
            }
            ?>
        </table>
    </div>
</body>

</html>