<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width='device-width', initial-scale=1.0">
    <title>Consulta Carro</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <h1>SELECIONE O FINAL DA SUA PLACA</h1>
    <br><br>
    <form action="recebe.php" method="post">
        <select name="placa">
            <option value="0">0</option>
            <option value="1">1</option>
            <option value="2">2</option>
            <option value="3">3</option>
            <option value="4">4</option>
            <option value="5">5</option>
            <option value="6">6</option>
            <option value="7">7</option>
            <option value="8">8</option>
            <option value="9">9</option>
        </select>
        <br><br>
        <input type="submit" value="VERIFICAR" class="botao">
    </form>
</body>
</html>