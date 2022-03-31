<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Conversão de tempo</title>
</head>
<body>
    <h1>CONVERSÃO DE TEMPO</h1>
    <form action="recebe.php" method="post">
        <span>Informe o valor que deseja converter</span>
        <input type="number" name="tempo">
        <br><br>
        <input type="radio" name="medida" value="dia_hora">
        <input type="radio" name="medida" value="hora_minuto">
        <input type="radio" name="medida" value="minuto_segundo">
    </form>
</body>
</html>