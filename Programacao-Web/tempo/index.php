<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Conversão de tempo</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <h1>CONVERSÃO DE TEMPO</h1>
    <form action="recebe.php" method="post">
        <span>Informe o valor que deseja converter</span>
        <input type="number" name="tempo" required>
        <div>
            <input type="radio" name="medida" value="dia_hora" required>
            <span>Dias para horas</span><br>
            <input type="radio" name="medida" value="hora_minuto">
            <span>Horas para minutos</span><br>
            <input type="radio" name="medida" value="minuto_segundo">
            <span>Minutos para segundos</span>
        </div>
        <input type="submit" value="Calcular" class="botao">
    </form>
</body>
</html>