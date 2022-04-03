<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Média</title>
    <style>
        h1{
            color: red;
            font-family: Arial, Helvetica, sans-serif;
        }
        span{
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <h1>MÉDIA DE NOTA</h1>
    <form action="recebe.php" method="post">
        <span>Informe a primeira nota:</span><br>
        <input type="number" name="nota1" step="any">
        <br><br>

        <span>Informe a segunda nota:</span><br>
        <input type="number" name="nota2" step="any">
        <br><br>

        <span>Informe a terceira nota:</span><br>
        <input type="number" name="nota3" step="any">
        <br><br>

        <span>Informe a quarta nota:</span><br>
        <input type="number" name="nota4" step="any">
        <br><br>

        <input type="submit" value="Calcular">
    </form>
</body>
</html>