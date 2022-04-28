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
    <h1>EXERCÍCIO 3</h1>
    <p>Programa que <strong>REPETE</strong> frases conforme o preenchimento do formulario</p>
    <hr>
    <form method="POST" action="">
        <label for="frase">Frase:</label>
        <textarea name="frase" cols="30" rows="2" autofocus="true" required></textarea>
        <label for="qtd">Quantidade:</label>
        <input type="number" name="qtd" min="1" value="" required>
        <br>
        <input type="submit" class="botao" value="Executar">
    </form>
    <?php
        if ($_SERVER['REQUEST_METHOD'] === 'POST') 
        {
            $frase = $_POST['frase'];
            $qtd = $_POST['qtd'];

            echo "<h2>RESULTADO</h2>";

            for ($i = 1; $i <= $qtd; $i ++)
            {
                echo "<p>$i: $frase</p><hr>";
            }
        }
    ?>
</body>
</html>