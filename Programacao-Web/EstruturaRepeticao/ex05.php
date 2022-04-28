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
    <h1>EXERCÍCIO 5</h1>
    <p>Programa que exibe a tabuada de um <strong>número</strong> escolhido</p>
    <hr>
    <form method="POST" action="">
        <label for="qtd">Número:</label>
        <input type="number" name="numero" min="1" required>
        <br>
        <input type="submit" class="botao" value="Executar">
    </form>
    <?php
        if ($_SERVER['REQUEST_METHOD'] === 'POST') 
        {
            $numero = $_POST['numero'];
            echo "<h2>RESULTADO</h2>";
            for ($i = 1; $i <= 10; $i++)
            {
                echo "<p>" . str_pad($i, 2, '0', STR_PAD_LEFT) . " X " . 
                str_pad($numero, 2, '0', STR_PAD_LEFT) . " = " . 
                str_pad($numero * $i, strlen($numero * 10), '0', STR_PAD_LEFT) . "</p><hr>";
            }
        }
    ?>
    </table>
</body>
</html>