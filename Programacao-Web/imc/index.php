<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Calculadora IMC</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <h1>CALCULADORA IMC</h1>
    <form action="recebe.php" method="post">
        <span>Informe seu peso</span>
        <input type="number" name="peso" step="any" required><br>
        <span>Informe sua altura</span>
        <input type="number" name="altura" step="any" required>
        <input type="submit" value="CALCULAR" class="botao">
    </form>
</body>
</html>